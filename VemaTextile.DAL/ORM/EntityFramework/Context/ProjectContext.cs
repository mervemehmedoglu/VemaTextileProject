using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Aciklama;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Alinan;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.CariHesap;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.CRM;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.EylemveGorev;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.FaturaBilgi;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.GeriOdeme;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Islemler;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.KarmaKoliler;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Kods;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Kullanici;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Muhasebe;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Odeme;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Proje;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.SonEvrak;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Stok;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Taahhut;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Tahsilat;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Teklif;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Uretim;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Usta;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Verilen;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Context
{
    class ProjectContext : DbContext
    {
        public ProjectContext() : base("name=dbConn")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectContext>());
        }
        public DbSet<AciklamaTanimlar> AciklamaTanimlars { get; set; }
        public DbSet<AlinanCekler> AlinanCeklers { get; set; }
        public DbSet<AlinanSenetler> AlinanSenetlers { get; set; }
        public DbSet<CariHesapİslemleri> CariHesapİslemleris { get; set; }
        public DbSet<CariHesapKartlari> CariHesapKartlaris { get; set; }
        public DbSet<CRMCode> CRMCodes { get; set; }
        public DbSet<EylemVeGorevler> EylemVeGorevlers { get; set; }
        public DbSet<FaturaBilgileri> FaturaBilgileris { get; set; }
        public DbSet<GeriOdemeIslemleri> GeriOdemeIslemleris { get; set; }
        public DbSet<GeriOdemePlani> GeriOdemePlanis { get; set; }
        public DbSet<KarmaKoli> KarmaKolis { get; set; }
        public DbSet<KarmaKoli2> KarmaKoli2s { get; set; }
        public DbSet<KOD> KODs { get; set; }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<MuhasebeEntegrasyonTablosu> MuhasebeEntegrasyonTablosus { get; set; }
        public DbSet<MuhasebeGrupKartlari> MuhasebeGrupKartlaris { get; set; }
        public DbSet<MuhasebeHesapKartlari> MuhasebeHesapKartlaris { get; set; }
        public DbSet<MuhasebeIslemleri> MuhasebeIslemleris { get; set; }
        public DbSet<MuhasebeIsletme> MuhasebeIsletmes { get; set; }
        public DbSet<MuhasebeIsletmeKodlari> MuhasebeIsletmeKodlaris { get; set; }
        public DbSet<MuhasebeMasrafMerkeziKartlari> MuhasebeMasrafMerkeziKartlaris { get; set; }
        public DbSet<OdemePlani> OdemePlanis { get; set; }
        public DbSet<ProjeGorevAciklama> ProjeGorevAciklamas { get; set; }
        public DbSet<ProjeGorevler> ProjeGorevlers { get; set; }
        public DbSet<ProjeKategoriler> ProjeKategorilers { get; set; }
        public DbSet<ProjeKaynaklar> ProjeKaynaklars { get; set; }
        public DbSet<ProjeTakibi> ProjeTakibis { get; set; }
        public DbSet<Sayimİslemleri> Sayimİslemleris { get; set; }
        public DbSet<SilinenKayitlar> SilinenKayitlars { get; set; }
        public DbSet<SiparisIslemleri> SiparisIslemleris { get; set; }
        public DbSet<SonEvrakNotlar> SonEvrakNotlars { get; set; }
        public DbSet<StokIslemleri> StokIslemleris { get; set; }
        public DbSet<StokKartlari> StokKartlaris { get; set; }
        public DbSet<TaahhutAciklama> TaahhutAciklamas { get; set; }
        public DbSet<TaahhutIsTakibi> TaahhutIsTakibis { get; set; }
        public DbSet<TaahhutKesifOzeti> TaahhutKesifOzetis { get; set; }
        public DbSet<TaahhutMaliyet> TaahhutMaliyets { get; set; }
        public DbSet<TaahhutMDetay> TaahhutMDetays { get; set; }
        public DbSet<TaahhutPrimTakibi> TaahhutPrimTakibis { get; set; }
        public DbSet<TaahhutProjeTakibi> TaahhutProjeTakibis { get; set; }
        public DbSet<TaahhutTeklif> TaahhutTeklifs { get; set; }
        public DbSet<TaahhutTeklifMaliyet> TaahhutTeklifMaliyets { get; set; }
        public DbSet<TaahhutTeklifUstaBilgileri> TaahhutTeklifUstaBilgileris { get; set; }
        public DbSet<TaahhutUstaBilgileri> TaahhutUstaBilgileris { get; set; }
        public DbSet<TahsilatPlani> TahsilatPlanis { get; set; }
        public DbSet<TeklifAciklama> TeklifAciklamas { get; set; }
        public DbSet<TeklifIslemleri> TeklifIslemleris { get; set; }
        public DbSet<UretimRecetesi> UretimRecetesis { get; set; }
        public DbSet<UstaKartlari> UstaKartlaris { get; set; }
        public DbSet<VerilenCekler> VerilenCeklers { get; set; }
        public DbSet<VerilenSenetler> VerilenSenetlers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new AciklamaMap());
            modelBuilder.Configurations.Add(new AlinanCeklerMap());
            modelBuilder.Configurations.Add(new AlinanSenetlerMap());
            modelBuilder.Configurations.Add(new CariHesapİslemleriMap());
            modelBuilder.Configurations.Add(new CRMCodeMap());
            modelBuilder.Configurations.Add(new EylemVeGorevlerMap());
            modelBuilder.Configurations.Add(new FaturaBilgileriMap());
            modelBuilder.Configurations.Add(new GeriOdemeIslemleriMap());
            modelBuilder.Configurations.Add(new GeriOdemePlaniMap());
            modelBuilder.Configurations.Add(new SayimIslemleriMap());
            modelBuilder.Configurations.Add(new SilinenKayitlarMap());
            modelBuilder.Configurations.Add(new SiparisİslemleriMap());
            modelBuilder.Configurations.Add(new KarmaKoli2Map());
            modelBuilder.Configurations.Add(new KarmaKoliMap());
            modelBuilder.Configurations.Add(new KodMap());
            modelBuilder.Configurations.Add(new KullanicilarMap());
            modelBuilder.Configurations.Add(new MuhasebeEntegrasyonTablosuMap());
            modelBuilder.Configurations.Add(new MuhasebeGrupKartlariMap());
            modelBuilder.Configurations.Add(new MuhasebeHesapKartlariMap());
            modelBuilder.Configurations.Add(new MuhasebeIslemleriMap());
            modelBuilder.Configurations.Add(new MuhasebeIsletmeKodlariMap());
            modelBuilder.Configurations.Add(new MuhasebeIsletmeMap());
            modelBuilder.Configurations.Add(new MuhasebeMasrafMerkeziKartlariMap());
            modelBuilder.Configurations.Add(new OdemePlaniMap());
            modelBuilder.Configurations.Add(new ProjeKaynaklarMap());
            modelBuilder.Configurations.Add(new ProjeGorevAciklamaMap());
            modelBuilder.Configurations.Add(new ProjeGorevlerMap());
            modelBuilder.Configurations.Add(new ProjeKategorilerMap());
            modelBuilder.Configurations.Add(new ProjeTakibiMap());
            modelBuilder.Configurations.Add(new SonEvrakNotlarMap());
            modelBuilder.Configurations.Add(new StokIslemleriMap());
            modelBuilder.Configurations.Add(new StokKartlariMap());
            modelBuilder.Configurations.Add(new TaahhutAciklamaMap());
            modelBuilder.Configurations.Add(new TaahhutIsTakibiMap());
            modelBuilder.Configurations.Add(new TaahhutKesifOzetiMap());
            modelBuilder.Configurations.Add(new TaahhutMaliyetMap());
            modelBuilder.Configurations.Add(new TaahhutMDetayMap());
            modelBuilder.Configurations.Add(new TaahhutPrimTakibiMap());
            modelBuilder.Configurations.Add(new TaahhutProjeTakibiMap());
            modelBuilder.Configurations.Add(new TaahhutTeklifMaliyetMap());
            modelBuilder.Configurations.Add(new TaahhutTeklifMap());
            modelBuilder.Configurations.Add(new TaahhutTeklifUstaBilgileriMap());
            modelBuilder.Configurations.Add(new TaahhutUstaBilgileriMap());
            modelBuilder.Configurations.Add(new TahsilatPlaniMap());
            modelBuilder.Configurations.Add(new TeklifAciklamaMap());
            modelBuilder.Configurations.Add(new TeklifIslemleriMap());
            modelBuilder.Configurations.Add(new UretimRecetesiMap());
            modelBuilder.Configurations.Add(new UstaKartlariMap());
            modelBuilder.Configurations.Add(new VerilenCeklerMap());
            modelBuilder.Configurations.Add(new VerilenSenetlerMap());
            modelBuilder.Conventions.Add(new PluralizingTableNameConvention());
        }
    }
}
