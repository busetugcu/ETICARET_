 using ETİCARET.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETİCARET.Context
{
    public class Initializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { Name = "Cilt Bakımı", Description = "Cilt Bakımı Ürünleri" },
                new Category() { Name = "Makyaj", Description = "Makyaj Ürünleri" },
                new Category() { Name = "Parfüm & Deodorant", Description = "Parfüm & Deodorant Ürünleri" },
                new Category() { Name = "Saç Bakımı", Description = "Saç Bakımı Ürünleri" },
                new Category() { Name = "Epilasyon & Tıraş", Description = "Epilasyon & Tıraş Ürünleri" }
            };
            context.Categories.AddRange(kategoriler);

            context.SaveChanges();


            var urunler = new List<Product>()
            {
                new Product(){ Name = "Cerave Neemlendirici Yüz Kremi",Description = "Normal ve Yağlıya Dönük Ciltler İçin •Cilt için gerekli 3 temel seramid, hyalüronk asit ve niasinamid ile cildin koruyucu bariyerinin onarılmasına ve doğal nem seviyesini korumaya yardımcı olur. •Köpüren, jel kıvamdadır. •Yüz ve vücut için kullanılabilir. •Çocuk ve yetişkinlerin kullanımına uygundur. •Komedojenik değildir, gözenekleri tıkamaz. •Parfüm içermez. Cildi nazikçe ve kurutmadan temizler, yağı ve kiri arındırır. Cildin nem dengesini korur.", Price =227 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image="4.png"},
                new Product(){ Name = "Four Win Aydınlatıcı & Renk Eşitleyici C Vitamini Serum",Description = "Cilde etkili ve hızlı bir şekilde nüfuz ederek, soyucu etki gösterir. Hücre yenilenmesini teşvik ederek cildin pürüzsüz, yumuşak ve nemli bir görünüm kazanmasına katkı sağlar. Prebiulin: Cilt mikrobiyotasının dengelenmesine yardımcı olan prebiyotik nemlendicidir. Cilt florasının yeniden düzenlenmesinde etkilidir.", Price =229 , Stock =500 , IsApproved =false , CategoryId = 1,IsHome = true,Image="5.png"},
                new Product(){ Name = "La Roshe Posay Effacler Mikro Soyucu Tonik Yağlı/Akneye Eilim Gösteren Ciltler Gözenek Sıkılaştırıcı",Description = "La Roche-Posay Effaclar 200 ml mikro soyucu tonik etkili bakım sağlayan bir üründür. Solüsyon içeriğinde teni arındıran ve temizleyen bir bileşim mevcuttur. Özel geliştirilmiş bir bileşime sahip olan solüsyon, bakım rutini için idealdir. Bu ürün, cildi temizlerken rahatlama da sağlar. Toniği kullanarak yüzünüzdeki sivilce, akne ve siyah noktalardan kurtulabilir ve bu zararlı oluşumların tekrarlanmasını önleyebilirsiniz. La Roche-Posay Effaclar akneli ciltler için gözenek sıkıştırıcı 200 ml mikro soyucu tonik oldukça kolay bir kullanıma sahiptir. ", Price =450 , Stock =500 , IsApproved =false , CategoryId = 1,IsHome = true,Image="6.png"},


                new Product(){ Name = "Avon Incandessence Kadın Parfüm Vücut Losyonu Rollon Üçlü Paket", Description = "Paket İçeriği : ? Avon Incandessence Kadın Parfüm Edp 50 Ml. ? Avon Incandessence Kadın Roll On 50 Ml. ? Avon Incandessence Kadın Vücut Losyonu 150 Ml.",Price =250 , Stock =500 , IsApproved =true,IsHome=true, CategoryId = 2,Image="7.png"},
                new Product(){ Name = "FREE LOVE Eurodream Edp Meyveli Çiçeksi Kadın Parfüm",Description = "Free Love Eurodream EDP Kadın Parfümü, meyve özleriyle zenginleştirilmiş özel bir koku deneyimi sunan bir kadın parfümüdür. Bu parfüm, tatlı ve ferah notalarıyla kendinizi şımartmanızı sağlar. Tepe notalarında nar, ahududu, çarkıfelek, Trabzon hurması, şeftali ve yeşil notalar bulunur. Bu notalar, enerjik ve canlı bir başlangıç sunar. Orta notalarda orkide, lotus ve şampanya bulunur. Bu notalar, çiçeksi ve sofistike bir dokunuş ekleyerek parfüme derinlik ve zarafet katar. Baz notalarında odun, amber, misk, menekşe, paçuli ve vanilya bulunur. Bu notalar, parfümün kalıcılığını ve sıcaklığını artırırken, birlikte yumuşak, büyüleyici ve çekici bir koku oluşturur. Bu şık cam şişe, kendi kokunuzu keşfetmenizi sağlar ve tüm cilt tipleri için uygun bir seçenektir.", Price =145 , Stock =750 , IsApproved =true , CategoryId = 2,IsHome = true,Image="8.png"},
                new Product(){ Name = "Avon Pur Blanca Kadın Parfüm ",Description = "Çiçek kokuları beyaz Frezya çiçeği ve ylang ylang kokularının üst notaları oluşturduğu parfüm orta notalarda beyaz çiçekler, şakayık, gül, su zambağı ile devam eder. Parfüm, sandal ağacı ve vanilya çiçeği kokularıyla son bulur.\r\nÜrün %100 orijinaldir", Price =230 , Stock =0 , IsApproved =false , CategoryId = 2,IsHome = true,Image="10.png"},


                new Product(){ Name = "Reshell Saç Dökülmesine Karşı Bakım Şampuanı At Kuyruğu Özlü Tuzsuz Kolajen Ve Keratin Katkılı ",Description = "Keratin ve Kolajen Şampuan Saç Dökülmesine Karşı Bakım Şampuanı At kuyruğu bitkisi özü Tuzsuz Keratin Katkılı", Price =199 , Stock =300 , IsApproved =true , CategoryId = 3,Image="9.png"},
                new Product(){ Name = "Elidor Superblend Saç Bakım Şampuanı Güçlü Ve Parlak 400 ml X3 Saç Bakım Kremi",Description = "Elidor Güçlü ve Parlak saç güçlendirici şampuan, Superblend karışımıyla saça ihtiyacı olan vitaminleri, proteinleri ve yağları sağlayıp saça kökten uca güç verirken gün boyu göz alıcı parlaklık sağlar.", Price =185 , Stock =100 , IsApproved =true , CategoryId = 3,Image="11.png"},
                new Product(){ Name = "DAİLY DREAM CARE Dökülmeyi Engelleyen Ve Saç Oluşumunu Destekleyen 2 ‘ Li Biotin Şampuan",Description = "Daily Dream Care Dökülmeyi Engelleyen Ve Saç Oluşumunu Destekleyen Biotin Şampuan 400 ML + 400 ML", Price =340 , Stock =0 , IsApproved =false , CategoryId =3,IsHome = true,Image="12.png"},


                new Product(){ Name = "Flormar Mat Likit Kalem Eyeliner (Siyah) - Midnight Matte Eyeliner ",Description = "Metallic lip charmer matte, yumuşak dokusu sayesinde kolaylıkla uygulanır, dudaklarında kadifemsi bir etki yaratır", Price =150 , Stock =500 , IsApproved =true , CategoryId = 4,Image="13.png"},
                new Product(){ Name = "Pastel Cream Blush 42 Rosery - Krem Allık PASTEL PROFASHION KREM ALLIK 42",Description = "Hafif yapısı ve krem formülü sayesinde ciltle tamamen bütünleşerek yanaklarda doğal ve taze bir görünüm sunar. Zengin pigmentler ve cilde uyum sağlayan yapısı sayesinde istenilen oranda boyama gücü vererek yüz hatlarını ortaya çıkarır. Kalıcılık ve yağ kontrolü sağlayan bileşenler içerir.", Price =85, Stock =400 , IsApproved =true , CategoryId = 4,IsHome = true,Image="14.png"},
                new Product(){ Name = "Maybelline New York Lash Sensational Sky High Cosmic Black Maskara ",Description = "Maybelline New York Lash Sensational Sky High Maskara   Tüm kirpiklerde kökten uca limitsiz uzunluk ve hacim etkisi!En küçük kirpiklere bile ulaşan esnek fırçası, bambu özü ve fiberler içeren 24saate kadar* kalıcı formülü ile hacimli, limitsiz uzunlukta simsiyah kirpik görünümüoluşturur,", Price =179 , Stock =0 , IsApproved =false , CategoryId =4,IsHome = true,Image="15.png"},

            };

            foreach (Product item in urunler)
            {
                context.products.Add(item);
            }
            context.SaveChanges();
        }
    }
}