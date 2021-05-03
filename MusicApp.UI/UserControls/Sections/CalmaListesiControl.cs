﻿using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.UserControls.Sections.List_Items;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls.Sections
{
    public partial class CalmaListesiControl : UserControl
    {
        private ICalmaListesiService _calmaListesiService;
        private ISarkiService _sarkiService;
        private ISanatciService _sanatciService;
        private ITurService _turService;

        public CalmaListesiControl()
        {
            InitializeComponent();
            _calmaListesiService = InstanceFactory.GetInstance<ICalmaListesiService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _turService = InstanceFactory.GetInstance<ITurService>();
        }

        private void calmaListesindenCikar(CalmaListesi calmaListesi)
        {
            _calmaListesiService.CalmaListesiSil(calmaListesi);
            MessageBox.Show("Çalma listesinden çıkarıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            calmaListesiGetir();
        }

        private void calmaListesiGetir()
        {
            pnlPop.Controls.Clear();
            pnlJazz.Controls.Clear();
            pnlKlasik.Controls.Clear();
            List<CalmaListesi> calmaListesi = _calmaListesiService.KullaniciCalmaListeleriniGetir(LoginManager.etkinKullanici.kullaniciId);
            if(calmaListesi.Count > 0)
            {
                CalmaListesiItem _calmaListesiItem;
                Sarki sarki;
                int popSayac=0,jazzSayac=0,klasikSayac = 0;
                foreach (CalmaListesi liste in calmaListesi)
                {
                    _calmaListesiItem = new CalmaListesiItem();
                    sarki = _sarkiService.SarkiGetir(liste.sarkiId);
                    _calmaListesiItem.lblMuzikAdi.Text = Regex.Replace(sarki.sarkiAdi, "(?<=^.{12}).*", "...");
                    _calmaListesiItem.lblSanatciAdi.Text = _sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi;
                    _calmaListesiItem.btnCikar.Click += (s, e) => calmaListesindenCikar(liste);
                    switch (_turService.TurGetir(liste.turId).turAdi.Trim().ToLower())
                    {
                        case "pop":
                            _calmaListesiItem.Top = (popSayac * 100);
                            pnlPop.Controls.Add(_calmaListesiItem);                            
                            popSayac++;
                            break;
                        case "jazz":
                            _calmaListesiItem.Top = (jazzSayac * 100);
                            pnlJazz.Controls.Add(_calmaListesiItem);                            
                            jazzSayac++;
                            break;
                        case "klasik":
                            _calmaListesiItem.Top = (klasikSayac * 100);
                            pnlKlasik.Controls.Add(_calmaListesiItem);                            
                            klasikSayac++;
                            break;
                    }                    
                }
            }
        }

        private void CalmaListesiControl_Load(object sender, EventArgs e)
        {
            calmaListesiGetir();
        }
    }
}
