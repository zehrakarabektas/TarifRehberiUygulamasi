using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab1tarifrehberiprojesi
{
    internal class Databasekodu
    {

    }

}
//USE tarifrehberidatabase;
//CREATE TABLE TariflerTablosu (
//    TarifID INT IDENTITY(1,1) PRIMARY KEY,
//    TarifAdi NVARCHAR(200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
//    KategoriAdi NVARCHAR(200) NOT NULL,
//    HazirlamaSüresi INT NOT NULL,
//    Talimatlar NVARCHAR(MAX) NOT NULL,
//    TarifResmi NVARCHAR(MAX)
//);
//CREATE TABLE MalzemelerTablosu(
//	MalzemeID INT IDENTITY(1,1) PRIMARY KEY,
//    MalzemeAdi NVARCHAR(200) NOT NULL,
//    ToplamMiktar VARCHAR(50) NOT NULL,
//    MalzemeBirim VARCHAR(20) NOT NULL,
//    BirimFiyat DECIMAL(5,2) NOT NULL
//);
//CREATE TABLE TarifMalzemeIliskisi (
//    TarifID INT NOT NULL,
//    MalzemeID INT NOT NULL,
//    MalzemeMiktar FLOAT NOT NULL,
//    PRIMARY KEY (TarifID, MalzemeID),
//    FOREIGN KEY (TarifID) REFERENCES TariflerTablosu(TarifID),
//    FOREIGN KEY (MalzemeID) REFERENCES MalzemelerTablosu(MalzemeID) 
//);

//INSERT INTO tarifrehberidatabase.dbo.TariflerTablosu (TarifAdi, KategoriAdi, HazirlamaSüresi, Talimatlar, TarifResmi) VALUES 
//('Mercimek Çorbası', 'Çorbalar', 45, 'Kırmızı mercimek çorbası için sıvı yağı tencereye alınarak yemeklik doğranan soğanlar hafif pembeleşinceye kadar kavrulur.  Daha sonra un ilave edilerek kısık ateşte kavurmaya devam edilir.  Salça kullanılacak ise salça ilave edilir, kavrulduktan sonra küp küp doğranmış havuç ve iyice yıkanıp suyu süzülen mercimekler ilave edilir.  Üzerine su eklenerek karıştırılır ve tencerenin kapağı kapatılır. Çorbamız kaynayana kadar orta ateşte, kaynadıktan sonra mercimekler ve havuçlar yumuşayana kadar ara ara karıştırılarak kısık ateşte pişirilir.  Çorba piştikten sonra el blenderı ile güzelce ezilir. Eğer blenderiniz yoksa süzgeçten de geçirebilirsiniz.  Karabiber, tuz ve isteğe bağlı olarak kimyon eklenir ve karıştırılır. 5 dakika daha pişirilerek ocaktan alınır.  Kıvamı koyu gelirse size, bir miktar su ilave edilerek bir taşım kaynatılır.  Bu arada küçük bir tavaya iki yemek kaşığı tereyağı alınır, kızdırılır ve bir tatlı kaşığı kırmızı toz biber eklenerek ocaktan alınır.  Mercimek çorbası servis kasesine alındıktan sonra üzerine kırmızı biberli sos gezdirilir ve bir dilim limon ile servis edilir.', 'mercimekcorbasi.png'),
//('Tarhana Çorbası', 'Çorbalar', 25, 'Tenceremizin içerisine sıvı yağ, nane, salça, baharatlar ve tarhanayı ekleyip biraz karıştırarak kavuruyoruz. Dilerseniz tereyağı da kullanabilirsiniz.( Veya tarhanayı suyu ekledikten sonra ekleyip çırpıcı ile karıştırabilirsiniz. böylelikle topaklanma ihtimali azalır.) Suyu yavaş yavaş ilave ediyoruz ve devamlı karıştırarak pişiriyoruz. Topaklanmaması için tel çırpıcı ile karıştırabilirsiniz. (kaynayana kadar karıştırarak pişirelim.) Kaynadıktan sonra 5 dk daha bekleyip ocaktan alıyoruz.', 'tarhanacorbasi.png'),
//('Domates Çorbası', 'Çorbalar', 35, 'Domates çorbası yapmak için öncelikle domateslerin kabuğu ince bir şekilde soyulur ve ikiye kesilip rondodan geçirilir. Dilerseniz  domatesleri rendeleyebilir ya da 2 su bardağı kadar domates sosu kullanabilirsiniz. Uygun bir tencerede tereyağı eritilir. Üzerine un eklenerek karıştırılır ve 1-2 dakika hafifçe kavrulur. Ocağı yüksek ateşte açarak unu yakmamaya dikkat etmelisiniz. Ardından rondodan geçirilen domatesler bu karışıma ilave edilir, birkaç dakika karıştırılarak kavrulur. Ara verilmeden 1 litre kadar su ilave edilip karıştırma işlemini sürdürülür. 15 dakika bu şekilde kaynatılır. Daha sonra süt ilave edilip birkaç dakika daha kaynatılır. Tuzu ilave edilip karıştırılır ve ocaktan alınır. Sütün oda sıcaklığında olmasına dikkat etmelisiniz. Arzuya göre servis yaparken üzerine kaşar peyniri rendesi ilave edilir. Domates çorbamız servise hazır.', 'domatescorbasi.png'),
//('Terbiyeli Tavuk Çorbası', 'Çorbalar', 50, 'Öncelikle tavukları haşlıyoruz. Ben küçük bir tencerede az miktarda yaptığım için ölçü böyle ve tavuk az siz miktarı ve tavuğu arttırıp daha fazla yapın, her şeyin 2 katı size ölçü olabilir. Bu ölçüler ile minik bir tencere çıkıyor. Tavuğu haşlayıp başka bir kaba suyunu süzelim. Tenceremizde tereyağı ve sıvı yağı eritip unu ekleyip kokusu çıkana kadar kavuralım. Sonra tavuk suyunu ekleyelim. Üzerine 1 bardak kadar da normal kaynar su ekleyelim. Eğer tavuk suyu tam gelirse başka suya gerek yok ama kesin gerekiyor çünkü kaynarken tavuk suyu biraz kayıp yaşıyor unutmamak lazım. O suda kaynara çıkınca tel şehriye ekleyelim. Başka bir yerde bir yumurta sarısı ve yarım limon suyu ile terbiye hazırlayalım. İşte bu kısım çok önemli. Çorbamızın kesilmemesi için; Terbiyeyi bir elle karıştırarak içine sıcak çorbadan alıp hemen karıştıralım. Terbiye iyice karışana kadar bu işlemi yapalım. Sonra çorbayı karıştıra karıştıra tencereye dökelim ve kaynara çıkana kadar sürekli karıştıralım ki kesilmesin. En önemli kısım burasıdır. Daha sonra indirmeye yakın pul biber, karabiber, tuz ve biraz maydanoz ekleyip 5 dk. daha kaynatıp altını kapayalım.', 'terbiyelitavukcorbasi.png'),
//('Yayla Çorbası', 'Çorbalar', 40, 'Yayla çorbası için ilk olarak pirinçler yıkanarak suda yumuşayıncaya kadar haşlanır.  Yayla çorbamızın terbiyesi için diğer taraftan yumurta sarısı, yoğurt, un bir kasede iyice çırpılır.  Pişen pirinçlere varsa et ya da kemik suyu yoksa 3 su bardağı sıcak su ilave edilir.  Çorbanın suyundan 1-2 kepçe alınarak yavaş yavaş alınıp terbiyeye ilave edilir.  Hafifçe sulanan bu karışım ılınmış olan çorbaya ilave edilir ve 1-2 taşım kaynatılır.  En son tuzu ilave edilir, bir kaç dakika daha kaynatılarak ocak kapatılır.  Üzerine sos için kuru nane eritilmiş tereyağında kızdırılarak gezdirilir. Yayla çorbamız servise hazır. Afiyet olsun.', 'yaylacorbasi.png'),
//('Düğün Çorbası', 'Çorbalar', 70, 'Etleri düdüklü tencereye alalım, üzerine suyu ilave ederek kapağını kapatalım ve 30-35 dakika pişmeye bırakalım.  Etler piştikten sonra hızlı bir şekilde soğuması için ayrı bir tabağa alalım. Etler soğuduktan sonra didikleyelim.  Diğer taraftan çorbanın terbiyesini hazırlayalım. Bunun için bir kaba yoğurt, unu, yumurta sarısını, limon suyu ve içme suyunu ilave ederek güzelce çırpalım.  Haşladığımız etin suyunu süzelim, çorba yapacağımız tencereye alalım. Yaklaşık 4 su bardağı et suyu çıkacaktır.  Hazırladığımız yoğurtlu karışımı et suyumuzun içine yavaş yavaş ve karıştırarak ilave edelim.  Kaynadıktan sonra didiklenmiş etleri de ekleyerek kısık ateşte çorbamızı kaynatalım.  Son olarak çorbanın tuzunu da ilave edelim, 5 dakika daha kaynatarak ocağı kapatalım.  Üzerine tereyağı ve pul biber ile hazırlamış olduğumuz sosu gezdirip servis yapalım.  Dilerseniz çorbayı içerken sirke de ilave edebilirsiniz. Afiyet olsun…', 'duguncorbasi.png'),
//('Ezogelin Çorbası', 'Çorbalar', 15, 'Ezogelin çorbası yapmak için düdüklü tencerede önce rendelemiş olduğumuz soğanı ve ezmiş olduğumuz sarımsağı tereyağında kavuruyoruz.  Soğanlar diriliğini kaybetsin yeterli yakmadan orta ateşte kavuralım.  Soğanlar kavrulunca naneyi, kırmızı biberi ve salçayı ilave edip. Kavurmaya devam edelim.  Bir iki karıştırdıktan sonra yıkadığımız mercimeği, pirinci, bulguru ve tuzunu da ilave ederek karıştıralım.  Başka bir tarafta kaynamakta olan 2 litreye yakın suyu üzerine boşaltalım.  Düdüklünün kapağını ve düdüğünü kapattıktan sonra 10 dakika pişiriyoruz. Normal tencerede de yapabilirsiniz ama biraz daha geç pişecektir (yaklaşık 30-40 dakika sürecektir).', 'ezogelincorbasi.png'),
//('Sebze Çorbası', 'Çorbalar', 30, 'Yıkayıp kabuklarını soyduğumuz kabak, havuç ve patatesleri küp küp doğrayalım ve defne yapraklarıyla beraber tencereye alalım. Bu tarifte önceden kabak dolması yapmak için oyduğunuz kabak içleriniz varsa onları da kullanabilirsiniz.  Sebzelerin üzerine sıcak su ilave edelim ve yumuşayıncaya kadar pişmeye bırakalım.  Ayrı bir tavada, tereyağı ve sıvı yağı eritelim.  Üzerine un ekleyerek, birkaç dakika kavuralım.  Karabiber ve kırmızı toz biberi de ekleyelim ve 1-2 dakika daha kavuralım, ateşten alalım.  Tencereden defne yapraklarını alalım ve yumuşayan sebzeleri blenderdan geçirelim.  Un ve baharatla kavurduğumuz yağı tencereye ekleyelim. Bu şekilde bir taşım daha kaynatalım.  Son aşamada, çorbaya süt ilavesini yapalım ve birkaç dakika daha pişirelim.  Tuzunu ekleyip, karıştıralım ve ocağı kapatalım.  İsteğe bağlı olarak, çorbamız piştikten sonra içerisine ince kıyılmış dereotu ilavesi de yapabilirsiniz.', 'sebzecorbasi.png'),
//('Kremalı Mantar Çorbası', 'Çorbalar', 60, 'Mantarları güzelce yıkayalım ve saplarını çıkarıp küp küp doğrayalım.  Sıvı yağ ve tereyağı tencereye koyup ince ince doğradığımız soğanı ekleyelim ve biraz pembeleşince, doğradığımız mantarları da ilave edelim ve suyunu salıp çekene kadar kavuralım.  Daha sonra, unu ekleyip 1 dakika daha kavurduktan sonra, 1,5 su bardağı sütü??(arzu eden paket krema da kullanabilir ama ben sütle yapıyorum gayet güzel oluyor) suyunu da ekleyip orta hararetli ateşte kaynamaya başlayana kadar karıştırarak pişirin.  Altını kısıp 10 dakika kadar kaynatın.  Ateşten almadan tuz ve karabiberini ve ince ince doğradığımız maydanozları da ekleyip bir taşım daha kaynatın çorbamız hazır.', 'kremalimantarcorbasi.png'),
//('Ayran Aşı Çorbası', 'Çorbalar', 70, 'Ayran aşı çorbası için 1 su bardağı buğdayı kaynayan suyun içerisine aktarın, üzerine su ilave ederek pişirmeye başlayın.  Pişen buğdayları ocaktan alın ve süzdürün.  Büyük bir karıştırma kasesinin içine 250 gram yoğurt ve süzme yoğurdu alıp çırpın.  1 su bardağı haşlanmış nohut ve buğdayı ekleyin. 1 tatlı kaşığı tuz da ilave ederek karıştırın.  Üzerine 1 su bardağı soğuk suyu azar azar ekleyerek kıvamını ayarlayın.  Ardından dereotunu da ekleyerek güzelce karıştırın.  Ayran aşı çorbasını 1 saat buzdolabında soğuttuktan sonra servis edin. Afiyet olsun!', 'ayranasicorbasi.png'),

//('Çoban Salatası', 'Salatalar', 5, 'İlk olarak domatesleri küçük küçük doğrayın ve karıştırma kabına alın.  Daha sonra soğanı da küçük küçük doğrayın ve üzerine tuz serpip elinizle güzelce ovun.  İnce ince doğradığımız yeşil biber ve küçük küçük doğradığımız salatalığımızı da karıştırma kabına alalım.  Son olarak maydanozu da ince ince doğrayalım ve doğradığımız diğer malzemelerimizin üzerine ekleyelim.  Salatamızın zeytin yağını ve limon suyunu da ekledikten sonra güzelce harmanlayalım ve servis tabağına alarak servis edelim. Afiyet olsun.', 'cobansalatasi.png'),
//('Mevsim Salatası', 'Salatalar', 10, 'Mevsim salatası için ilk olarak havuç ve turbun kabuklarını ince bir şekilde soyalım ve rendeleyelim.  Mor lahanayı ikiye bölerek doğrayalım. Mümkün olduğunca ince bir şekilde doğramaya dikkat edelim.  Ardından marulu ve maydanozu da ince ince doğrayalım.  Tüm malzemeleri hazırladıktan sonra derince bir salata kasesinin içerisine sebzelerimizi alalım.  Suyu süzülmüş konserve mısırı da salataya ilave edelim.  Ardından salatanın üzerine zeytinyağı, limonun suyu ve tuzu serperek ilave edelim.  Daha sonra tüm malzemeleri güzelce karıştıralım. Salatamız güzelce karıştırıldıktan sonra servise hazır. Afiyet olsun!', 'mevsimsalatasi.png'),
//('Patates Salatası', 'Salatalar', 35, 'Bir tencereye suyu alıp ısıtın. Su ısındıktan sonra patatesleri üzerine ekleyin ve haşlamaya başlayın. Yaklaşık 15-20 dakika sonra bıçağın ucuyla pişme derecesini kontrol edin ve ocaktan alıp suyunu süzün. Soğuması için dinlenmeye bırakın.  Derin bir kaseye oda sıcaklığında soğuyan patatesleri küp küp doğrayıp içerisine ekleyin.  Yeşillikler, sumak, karabiber ve tuzu ekleyin.  Zeytinyağı ve limon suyunu da patates salatasına ilave edin. Güzelce karıştırın.  Ardından patates salatasını servis edin. Afiyetler olsun!', 'patatessalatasi.png'),
//('Rus Salatası', 'Salatalar', 45, 'Küp küp doğranmış patates, havuç ve ayıklanmış bezelyeleri sıcak suda haşlamaya bırakın. Sebzelerin pişip pişmediğini kontrol edin. Haşlanan sebzeleri bir kevgirle süzdürerek soğuk su ve buz dolu bir kaseye aktarın. Bu işlem, sebzelerin hemen pişmeyi durdurarak ve soğuyarak salatanın tazeliğini korumasına yardımcı olacaktır.  Mayonez, yoğurt, tuz ve karabiberi bir kaseye koyun. Bu sos, salatanıza kremamsı bir dokunuş katacaktır.  Soğuyan ve süzülen sebzeleri hazırladığınız sostan kaseye ekleyin. Kornişon turşularını da ufak ufak doğrayın. Bu aşamada malzemeleri karıştırmadan önce, her bir malzemenin sos ile güzelce kaplanmasına dikkat edin.  Tüm malzemeleri karıştırarak sosun ve baharatların sebzelerle homojen bir şekilde buluşmasını sağlayın. Bu adımda spatula veya büyük bir kaşık kullanarak nazikçe karıştırın.  Rus salatası hazır! Üzerini isteğe bağlı olarak maydanoz veya yeşilliklerle süsleyebilirsiniz. Bu nefis salatayı yanında bir dilim ekmek veya ana yemek olarak tüketebilirsiniz.', 'russalatasi.png'),
//('Mor Lahana Salatası', 'Salatalar', 25, 'Mor lahana salatası hazırlamak için öncelikle lahanayı ince ince doğrayın ve az yağda, kendi suyunda yumuşayıncaya kadar kavurun.  Burada lahananızı bıçak ile doğramak yerine patates soyacağı ile de incecik kıyabilirsiniz.  Uygun bir kase içerisine yoğurt, mayonez, tuz ve dövülmüş sarımsağı ekleyip karıştıralım. İsteğinize göre mayonez ve yoğurt miktarını ayarlayabilirsiniz.  Lahanalarımızı karıştırma kabına alalım, yoğurtlu sosu da ekleyerek karıştıralım.  Dilediğiniz gibi süsleyerek servis edebilirsiniz.', 'morlahanasalatasi.png'),
//('Cevizli Roka Salatası', 'Salatalar', 5, 'İlk başta rokaları sirkeli suya koyup 10 dakika kadar bekletin. (Mikroplardan arınması için)  Ardından suyla yıkayıp süzgece alıp süzülmesini bekleyin.  Roka, domates ve soğanı doğrayıp salata kabına alınız.  Üzerine ufaladığımız ceviz, sumak, tuz, limon ve zeytinyağını ekleyerek karıştıralım.', 'cevizlirokasalatasi.png'),
//('Yoğurtlu Kabak Salatası', 'Salatalar', 10, 'Öncelikle kabakların kabuklarını soyacak yardımıyla ince bir şekilde soyalım.  Soyduğumuz kabakları hızlıca bir sudan geçirerek rendelemeye başlayalım.  Kabakların hepsini rendeledim, şimdi derin bir tavaya 2 yemek kaşığı kadar sıvı yağ alalım.  Rendelenen kabakları tavaya alarak kabaklar suyunu çekinceye kadar soteleyelim.  Orta ateşte kabaklar suyunu çekinceye kadar pişirmeye devam edelim.  Diğer taraftan bir avuç dereotunu ince ince kıyalım.  Ardından derince bir kaseye  süzme yoğurdu alalım.  Süzme yoğurdun üzerine tuz ve  ezilmiş sarımsağı ilave ederek pürüzsüz bir kıvam alıncaya kadar çırpalım. Yine tuz ve sarımsak miktarını kendi damak zevkinize göre ayarlayabilirsiniz. İstemiyorsanız sarımsak kullanmak zorunda değilsiniz.  Bu arada pişen ve suyunu tamamen çeken kabakları tavadan bir tabağa aktararak soğuyuncaya kadar bekletelim.  Yeterince soğumasını beklediğimiz kabakları sarımsaklı yoğurda ilave edelim.  Ardından suyu süzülmüş konserve mısır, isteğe bağlı olarak  ceviz, son olarak da doğradığımız dereotunu ilave edelim.  Salatamızı güzelce karıştıralım.  Bu aşamada bu salataya yakışacağını düşündüğünüz farklı malzemeler varsa onları da ekleyebilirsiniz.  Bir servis tabağına salatamızı aktaralım.  Üzerine bir yemek kaşığı kadar zeytinyağı gezdirdikten sonra renk vermesi için biraz da pul biber serpelim. Yoğurtlu kabak salatamız artık hazır.', 'yogurtlukabaksalatasi.png'),
//('Tabule Salatası', 'Salatalar', 20, 'İnce bulgur bir kaba alınarak, üzerini ıslatacak kadar sıcak su eklenir ve kapağı kapatılarak, 20 dakika kadar yumuşaması için bekletilir.  Bu sırada, taze nane mümkün olduğunca ince doğranarak karıştırma kabına alınır.  Maydanoz ve yeşil soğanda doğranarak nanelerin yanına alınır.  Domates, çok minik küpler halinde doğranır.  Sıcak suda beklettiğimiz bulguru, nar ekşisi, limon suyu, zeytinyağı ve tuz yeşilliklerin üzerine eklenir ve güzelce karıştırılır.  Hazır olan tabulemiz servis tabağına alınarak üzeri nar ile süslenir ve servis edilir.', 'tabulesalatasi.png'),
//('Gavurdağ Salatası', 'Salatalar', 10, 'Domatesler ve yeşil biber küçük küçük doğranır.  Yeşil soğanlar ve maydanozlar da çok ince kıyılır.  Kuru soğan mümkün olduğunca küçük doğranarak biraz tuzla ovulur.  Bütün malzeme geniş bir kaba alınır, iri kırılmış cevizler, zeytinyağı ve nar ekşisi ilave edilir.  Göz kararı yaklaşık 1 yemek kaşığı sumak da eklenir.  Karıştırılarak servis tabağına alınır.  Zeytinyağının, nar ekşisinin ve cevizin miktarını kendi zevkinize göre ayarlayabilirsiniz.  Afiyet olsun!', 'gavurdagsalatasi.png'),
//('Makarna Salatası', 'Salatalar', 30, 'Yoğurtlu makarna salatası için kaynayan tuzlu su içerisine tuz ve boncuk makarnayı ilave ederek, paketin arkasında yazan süreye göre haşlayalım. Kornişon turşularımızı küçük küçük doğrayalım. Makarna salatasının sosu için uygun bir karıştırma kabına yoğurt, mayonez, sarımsak ve tuzu alarak tel çırpıcı yardımıyla çırpalım. Bu aşamada kullandığınız yoğurdun süzme yoğurt olması salatanızın daha iyi olmasını sağlayacaktır. Eğer normal yoğurt kullanacaksanız suyunu süzerek kullanmanızı tavsiye ederim. Haşlanan makarnaların suyunu süzelim ve geniş bir kaseye aktaralım. Üzerine hazırladığımız yoğurtlu sosu, hazır garnitürü ve doğradığımız turşuları ekleyerek güzelce karıştıralım.', 'makarnasalatasi.png'),

//('Fırında Sütlaç', 'Tatlılar', 70, 'Fırında sütlaç için öncelikle pirinci haşlayalım. Pirinçleri güzelce yıkadıktan sonra 2 su bardağı su ile pirinçler yumuşayıp pişene kadar haşlayın. Çok az sulu kalacaktır. Diğer malzemeleri ekleyelim ve sütlacı pişirelim. Haşlanan pirinçlerin üzerine sütü, vanilyayı ilave edip kaynatın. Bu arada bir kap içerisinde nişasta ve sütü (suyu) pürüzsüz kıvam alıncaya kadar karıştırın. Karışım kaynamaya başlayınca şekeri ve yarım su bardağı sütle karıştırdığınız 3 yemek kaşığı buğday nişastasını ilave ediniz. 10-15 dk. daha kaynatıp ocağın altını kapatın. Sütlaçları fırına sürelim. Fırın için uygun ısıya dayanıklı sütlaç kaselerine sütlaçlarınızı paylaştırın. Tepsinize soğuk su doldurun ve sütlaç kaplarını fırın tepsinize dizin (Tepsideki su sütlaç kaplarının yarısına kadar gelecek). Tepsiyi fırınınızın en üst rafına yerleştirin. 180 derecede, sütlaçlarınız kızarana kadar fırınlayın. Afiyet olsun. Not: Toprak kase kullanacaksanız bu tarife göre 6 adet çıkıyor.', 'firindasutlac.png'),
//('Kazandibi', 'Tatlılar', 50, 'Öncelikle orta boy bir tencereye bütün malzemeleri alarak karıştırıyoruz. Muhallebi elde ediyoruz. En son tereyağını ve vanilyasını dökerek muhallebimizi 5 dk. kadar pişiriyoruz. Orta boy alüminyum tepsiye bolca tereyağı sürüyoruz ve 3 yemek kaşığı kadar tepsiye şeker döküyoruz. Her yeri eşit olmasına özen gösterin. Sonra pişmiş muhallebiyi tepsiye döküyoruz ve orta ateşte sürekli olarak çevirerek muhallebiyi pişiriyoruz. 25-30 dk. yeterli burada önemli olan tepsiyi sürekli çevirerek kontrollü pişirmek kenar kısımların da pişmesine özen göstermek biraz dibi tutan muhallebinin kokusu biraz çıkar. O zaman hemen ocaktan alıyoruz ve soğumaya bırakıyoruz. Soğuduktan sonra 1-2 saat de buzdolabında bekletiyoruz. Sonra istediğimiz gibi dilimleyip servis yapabilirsiniz. Afiyet olsun.', 'kazandibi.png'),
//('Revani', 'Tatlılar', 45, 'Hamuru için karıştırma kabına yumurta ve toz şekeri alarak beyazlaşıp köpük köpük oluncaya kadar çırpalım. Daha sonra içerisine sıvı yağ, yoğurt, irmik, vanilya, kabartma tozunu ilave edelim ve spatula yardımıyla tüm malzemeyi güzelce karıştıralım. Kabımızın üzerini streç filmle kapatarak yaklaşık 2 saat dinlendirelim. Bu arada hamuru her yarım saatte bir karıştıralım ve üzeri kapalı olacak şekilde bekletmeye devam edelim. Bu işlem kek hamurumuzun kıvamının gittikçe koyulaşmasını sağlayacaktır. Sürenin sonunda hamuru, tabanını sıvı yağ ile yağladığımız 35×25 santimetrelik fırın kabımıza aktaralım. Tatlımızı önceden ısıttığımız 170 derece fırında 30 dakika pişmeye bırakalım. Tatlıyı fırına verdikten ilk 10 dakika sonra şerbeti hazırlamaya başlayalım. Bunun için tencereye toz şeker ve suyu alalım. Yüksek ateşte şeker eriyinceye kadar karıştıralım. Kaynayınca kısık ateşe alarak 10 dakika kaynamaya bırakalım. Birkaç damla limon suyunu da ilave edelim ve 5 dakika daha kaynatarak şerbeti ocaktan alalım. Pişen tatlıyı fırından alalım, üzerine hazırladığımız sıcak şerbeti gezdirerek dökelim. Bu tarifte şerbette tatlıda sıcak olacak. Hamur olur diye gözünüz korkmasın. Tatlımızın şerbetini çekebilmesi için bir kaç saat dinlenmeye bırakalım. Şerbetini çektikten sonra eşit parçalar halinde dilimleyelim. Ben 12 dilim olacak şekilde dilimledim. Gerçek revani tatlımız servise hazır. Üzerini süsleyerek servis edelim. Afiyet olsun!', 'revani.png'),
//('Tiramisu', 'Tatlılar', 45, 'Öncelikle muhallebi için şeker, un, süt ve yumurta çırpılır. Ocakta kaynayıncaya kadar karıştırılarak pişirilir.Kaynadıktan sonra altı kapatılır ve daha hızlı soğuması için ayrı bir kaba boşaltılır.15 dk kadar bekleyip ılındıktan sonra labne peyniri ilave edilip mikser ile pürüzsüz hale gelene kadar çırpılır.Diğer taraftan sıcak su içinde hazır kahve çözdürülerek hazırlanır ve hafif soğuması beklenir.Servis tabağına pandispanya kekinin bir katı yerleştirilerek kahvenin yarısı ile ıslatılır.Üzerine kremanın yarısı ilave edilip güzelce yayılır.Kalan kahve ile üst kat da ıslatıldıktan sonra pandispanyanın ikinci katı kremanın üzerine kapatılır.Kalan krema pastanın üzerine dökülerek pastanın üzeri ve kenarları güzelce spatula veya pasta sıvama aparatı ile kapatılır.Son olarak pastanın üzerine süzgeç yardımı ile kakao serpilir.Buzdolabında birkaç saat mümkünse 1 gece dinlendirildikten sonra dilimlenerek servis edilir.', 'tiramisu.png'),
//('Şekerpare', 'Tatlılar', 35, 'Öncelikle tatlımızın şerbeti için tencereye şeker ve suyu alalım. Karıştırdıktan sonra şerbeti kaynamaya bırakalım. 10 dakika kadar kaynayan şerbette limon suyunu ilave ederek karıştıralım. Şerbeti yaklaşık 5 dakika kaynattıktan sonra ocağı kapatıp soğuması için bir kenara alalım. Tatlının hamuru için karıştırma kabına oda sıcaklığındaki tereyağı ve pudra şekerini alarak güzelce karıştıralım. Yumurtayı da ekleyerek tüm malzemeyi güzelce karıştıralım. Ardından irmik, kabartma tozu, vanilya ve unu yavaşça ilave ederek hamuru yoğurmaya başlayalım. Hamurdan ceviz büyüklüğünde parçalar koparıp elimizle yuvarlayarak şekillendirelim. Şekillendirdiğiniz tatlıları tepsiye aralıklı olarak yerleştirelim. Şekerpareleri tepsiye sıraladıktan sonra isteğe bağlı olarak ortalarına birer tane fındık batıralım. Dilerseniz fındık yerine ceviz veya badem de kullanabilirsiniz. Tatlımızı önceden ısıttığımız 180 derece fırında fansız ayarda 30 dakika pişmeye bırakalım. Fırından aldığımız sıcak tatlının üzerine soğuyan şerbeti gezdirebiliriz. Bu aşamada tatlının hiçbir yerinin kuru kalmaması için şerbeti hepsine eşit bir şekilde gezdirmeye dikkat edelim. Şerbetini çekinceye kadar dinlendirdiğimiz tatlımız artık servise hazır. Afiyet olsun!', 'sekerpare.png'),
//('Yalancı Profiterol', 'Tatlılar', 40, 'Tencereye; 1 litre süt, yumurta sarıları, un, toz şeker ve nişasta koyulur, çırpma teli ile karıştırılır. Ocağa alınır, sürekli karıştırılarak koyulaşıp kaynaması sağlanır. (Koyu kıvamlı oluyor fazla koyu olduğunu düşünmeyin olması gereken kıvam bu) Kaynayıp koyulaşan krema ocaktan alınır 1 paket vanilya eklenerek karıştırılır. Kremaya temas edecek şekilde streçlenerek soğumaya bırakılır. 2 poşet krem şanti 1 su bardağı süt ile köpürtülür, buzdolabına alınır. Toz çikolata sosu 2, 5 su bardağı süt ile tencereye koyulur, sürekli karıştırılarak kaynaması sağlanır. Ocaktan alınır ara ara kabuk tutmaması için karıştırılarak soğutulur. Soğuyan beyaz kremanın içerisine hazırlanan krem şanti eklenerek mikserin yüksek devirin de 5-7 dakika homojen kıvama gelene kadar çırpılır. Kremanın içerisine Kedili bisküvileri 4 parçaya bölünerek eklenir. Spatula yardımı ile karıştırılır. Büyük boy kare veya yuvarlak borcama krema aktarılır, düzleştirilir. Üzerine tamamen soğuyan çikolata sosu dökülür ve çikolata parçacığı atılır. Buzdolabında en az 4 saat bekletilir.', 'yalanciprofiterol.png'),
//('Krem Karamel', 'Tatlılar', 60, 'Bir tavaya toz şeker ve suyu koyun. Ocakta kahverengi olana kadar karıştırın. Fırın tepsisine krem karamel kaplarını yerleştirin ve tepsinin içine kapların yarısına kadar ılık su doldurun. Krem karamel kaplarının içine kavurduğunuz şekerden birer çorba kaşığı ekleyin. Krem karamel harcını hazırlamak için sütü ısıtın. Ayrı bir çırpma kabına yumurtaları kırın. Üzerlerine toz şeker, limon kabuğu ve vanilyayı ekleyin. Bu malzemeleri iyice karıştırdıktan sonra ısıtılmış sütü ilave edin. Karışımı tel süzgeçten geçirin ve karamelin üzerine dökün. 180 derecede 40 dakika pişirin. 10 dakika bekledikten sonra buzdolabına alarak 3 saat bekletin. Daha sonra kapları ters çevirip servis edin. Afiyet olsun.', 'kremkaramel.png'),
//('Brownie', 'Tatlılar', 45, 'Tereyağını minik bir sos tenceresinin içerisinde eritin. Eridiği gibi ocaktan alın ve tereyağınız henüz sıcakken parça parça böldüğünüz çikolataları içerisine aktarın. Tereyağının sıcağı ile erimesini sağlayın. Ardından tereyağlı çikolata karışımını oda sıcaklığında soğuması için bir kenara alın. Bir kabın içerisine yumurtaları alın, şekeri de ilave ederek güzelce çırpın. Çırpılan şekerle yumurtaların üzerine azar azar tereyağlı çikolatalı karışımı aktarın ve karıştırmaya devam edin. Tüm karışımı ekleyip karıştırdıktan sonra un ve vanilyayı eleyerek üzerine ilave edin. Spatula yardımıyla brownie harcını tüm malzemeler birleşinceye dek katlayarak karıştırın. Ardından yağlanmış ya da pişirme kağıdı serilmiş 20 cmlik kare kek kalıbına hazırladığınız karışımı aktarın. Üst kısmını spatulayla düzeltin. 160 derecede önceden ısıtılmış fansız fırında 30-35 dakika kadar pişirin. Üzeri hafif çatlak bir görünüm alınca fırından çıkarın ve oda sıcaklığında en az 1 saat kadar dinlendirin. Brownie hazır. Dinlendikçe kıvamı güzelleşecektir. Dinlendikten sonra dilimleyerek servis edebilirsiniz. Afiyet olsun!', 'brownie.png'),
//('Çatlak Kurabiye', 'Tatlılar', 30, 'Karıştırma kabına tüm malzemeleri alalım ve karıştırıp yoğuralım. Elde ettiğimiz hamurun ele yapışmayan yumuşak bir hamur olması gerekiyor. Hazır olan hamurdan ceviz büyüklüğünde parçalar koparıp yuvarlayalım. Elimizle hafif bastırıp yağlı kağıt serili tepsiye aralıklı bir şekilde dizelim. Hazırladığımız kurabiyeleri önceden ısıtılmış 170 derecelik fırında altı kızarıp üstü çatlayana dek yaklaşık 25 dakika pişirelim. Pişme süresi ve derecesi fırından fırına farklılık gösterebileceği için kontrollü olmalısınız. Sürenin sonunda pişen kurabiyeleri fırından alıp soğuduktan sonra servis tabağına alabilirsiniz.', 'catlakkurabiye.png'),
//('Tavuk Göğsü', 'Tatlılar', 30, 'Tereyağını tencerede eritin ve unu ekleyerek kokusu çıkana kadar karıştırarak kavurun. Bir yandan da azar azar sütü eklemeye başlayın. Üzerine şekeri de ekleyin. Muhallebi kıvamına gelene kadar pişirin. Son olarak vanilyayı ekleyip ocaktan alın ve mikserle 3 dakika kadar çırpın. 22 cm ebatlarındaki borcamınızı ıslattıktan sonra muhallebiyi dökün ve spatula yardımıyla düzeltin. Oda ısısına geldikten sonra streçleyin ve buzdolabında 2-3 saat kadar bekletin. Buzdolabından alınca üzerine tarçın serpiştirerek servis edebilirsiniz.', 'tavukgogsu.png'),
//('Magnolya', 'Tatlılar', 30, 'Bir tencerenin içerisine süt, şeker, nişasta, un ve yumurta sarısını aktarın. Güzelce karıştırın. Orta ateşte, sürekli karıştırarak muhallebi kıvamına gelene dek pişirin. Ocaktan alıp vanilyayı ekleyin ve karıştırın. Ilımaya başlayan kremayı ilave ederek karıştırmaya devam edin. Bu sırada bisküvileri rondodan geçirin. Çileklerin saplarını çıkararak dilediğiniz boyutlarda kesin. Soğuyan pudinginizden birkaç kaşık alın. Bir kupun tabanına yayın. Üzerine bisküvi ve çileklerden ilave ederek katlar çıkın. Tüm bisküvi, puding ve çilekler bitene kadar kuplara bu şekilde bölüştürün. Ardından buzdolabında 3-4 saat kadar soğumaya bırakın. Servis aşamasında üzerini bisküvi, çilek ya da muz, çikolata sos gibi farklı malzemelerle süsleyerek servis edin. Magnolia tarifi hazır. Afiyet olsun!', 'magnolya.png'),

//('Sigara Böreği', 'Atıştırmalıklar', 15, 'Yufka üçgen şeklinde 12 eş parçaya bölünür. Doğranmış maydanoz ve peynir karıştırılarak iç harcı hazır edilir.Her üçgen yufkanın alt ucuna bir kaşık dolusu kadar peynir harcı yayılır.Yufkanın kenarlar malzeme dökülmemesi için içe doğru bükülür ve yufka rulo şeklinde sarılır.Uç kısmı su ile hafifçe ıslatarak kapatırsanız börekleriniz açılmayacaktır.Hazırlanan börekler kızgın yağda çevrilerek pişirilir.Dilerseniz boş bir zamanınızda hazırlayacağınız börekleri dolap poşeti ile derin dondurucuda muhafaza edebilir, yiyeceğiniz zaman istediğiniz kadarını kızartabilirsiniz. Afiyet olsun…', 'sigaraboregi.png'),
//('Mercimek Köftesi', 'Atıştırmalıklar', 80, 'Mercimek köftesi yapmak için mercimekler yıkanır ve uygun bir tencereye alınarak, üzerini 3 su bardağı su ilave edilir. İyice yumuşayıncaya kadar haşlanır.Suyunu çekince bulgur içine atılır ve yarım saat kadar tencerenin kapağı kapalı olarak bekletilir.Ayrı bir tavada ince kıyılmış soğan sıvı yağda hafif pembeleşene kadar kavrulur, içine salça ilave 1-2 dakika daha kavrularak ocaktan alınır.Yarım saat dinlenen mercimeklere, kavurduğumuz salçalı soğan eklenir ve el yakmayacak bir sıcaklığa geldiğinde, güzelce yoğurulur.İyice karışan köfte harcına tuz ve baharatlar ilave edilerek, tekrar yoğrulur.Son olarak ince kıyılmış maydanoz, ince kıyılmış yeşil soğan ilave edilir. Malzemelerin güzelce karışması sağlanırKöfte harcı biraz soğuduktan sonra, bütün malzemeler el ile yoğrularak yumurta büyüklüğünde parçalar koparılır.Köftelere şekil verilerek, marul veya roka yaprakları üzerine dizilir.', 'mercimekkoftesi.png'),
//('Mücver', 'Atıştırmalıklar', 30, 'Mücver için bol suda yıkadığınız kabakları rendenin iri kısmıyla rendeleyin. Mücveri sulandırmaması için; rendelenmiş kabakların suyunu sıkarak çıkartın.Geniş bir kapta rendelenen kabakları, havucu, yumurtayı, taze soğanı, dereotunu, tuzu, karabiberi birleştirin.Unu da ilave edip tüm malzemeler birbiriyle harmanlayın.Tüm malzemeler macun kıvamını alana kadar spatula yardımıyla karıştırın.Her bir mücver 1 tepeleme yemek kaşığı olacak şekilde ayarlayıp tavaya dökün.Kızgın yağda altın sarısı rengini alana kadar kızartın. Mücverlerin fazla yağını havlu kağıda süzdürdükten sonra servis tabağına alın ve çırpılmış yoğurt ile servis edin. Afiyet olsun!', 'mucver.png'),
//('Paçanga Böreği', 'Atıştırmalıklar', 25, 'İlk olarak paçanga böreğinin iç harcı hazırlanır. Biberler küçük küçük doğranarak az sıvı yağda sotelenir ve derin bir kap içerisine alınır. Dilerseniz çiğden de koyabilirsiniz ama ben 1-2 dakika önceden pişirmeyi tercih ediyorum. Biberler biraz soğuduktan sonra kabuğu soyulan ve küp küp doğranan domatesler, kaşar peyniri ve pastırmalar eklenip karıştırılarak iç harcı hazırlanır.Yufka ile börekler sarılır. Yufka büyüklüğüne göre 6 veya 8 üçgen parçaya bölünür. Her parçaya iç harcından bolca yerleştirilerek sigara böreği sarar gibi fakat daha irice sarılır.Hazırlanan paçanga börekleri kızartılır. Hazırlanan börekler bol sıvı yağda kızartılır. Sıcağıyla fazla bekletmeden servis yapmanızı öneririm. Afiyet olsun.Not: Malzeme miktarını kişi sayısına sayısına göre artırabilirsiniz. Fazla yapıp derin dondurucu da saklarsanız dilediğiniz zaman hızlıca kızartıp servis edebilirsiniz.', 'pacangaboregi.png'),
//('Kısır', 'Atıştırmalıklar', 20, 'Öncelikle bulguru sıcak suyla bir miktar ıslatıyoruz.Ama çok az su ile, sadece suyu döktüğümüz anda hemen kendisini çekecek kadar ve kapağını kapatıp 5 dakika demlendiriyoruz.Küçük bir tavada kuru soğanı ve sarımsağı, 1 yemek kaşığı zeytinyağı ile çok az kavurup salçasını ilave ediyoruz.2 dakika daha kavurup ocağı kapatıyoruz.Bulgurun içine döküyoruz ve bütün baharatları, nar ekşisini ve 1 çay bardağı zeytinyağını da ilave edip iyice harmanlıyoruz.İnce ince doğradığımız yeşillikleri ilave edip iyice birbirine yedirdikten sonra en son domateslerimizi ilave edip karıştırıyoruz ve servis yapıyoruz.', 'kisir.png'),
//('Lahmacun', 'Atıştırmalıklar', 30, 'Lahmacunumuzun iç harcı için bir kaç parçaya böldüğümüz soğanı, yeşil ve kırmızı biberi rondodan geçirelim.Daha sonra doğradığımız domatesi, sarımsağı, salçayı ve maydanozu da ekleyerek tekrar rondodan geçirelim.Hazırladığımız bu karışımı uygun bir kap içerisine alalım ve üzerine kıymayı, baharatları ve tuzu da ilave ederek tüm malzemeleri elimizle güzelce karıştıralım.Güzel bir kıvam alan harcımızın üzerini streçleyerek buzdolabında dinlenmeye bırakalım.Harcımız dinlenirken bizde hamurumuzu hazırlayalım. Lahmacun hamuru için uygun bir yoğurma kabına aldığımız unun üzerine tuz ve şekeri ekleyerek şöyle bir karıştıralım ve ortasını çukurlaştıralım.Açtığımız çukura suyu dökelim ve kenar kısımlardan un alarak hamurumuzu yoğurmaya başlayalım.Pürüzsüz bir hamur elde edene kadar yoğurma işlemine devam edelim.Hazır olan hamurumuzun üzerini de streçleyerek buzdolabına koyalım ve 20 dakika kadar dinlenmeye bırakalım.Dinlenen hamurumuzu un serptiğimiz tezgaha çıkaralım ve eşit bir şekilde 4 parçaya bölelim.Böldüğümüz parçaları da 3’e bölerek birbirine eşit 12 parça elde edelim.Hamurlarımızı dıştan içe doğru yoğurarak beze haline getirelim.Bezelerimizi tabağa alarak kurumaması için üzerini streç film ile tekrar kapatalım.Bezelerimizden bir tanesini tezgaha alalım ve üzerine un serpelim ve merdane yardımı ile açmaya başlayalım. Bezelerimizi mümkün olduğunca ince açmaya çalışalım.Yaklaşık 23-24 cm çapında açtıktan sonra pişirme kağıdını hamurumuzun altına yerleştirelim.Pişirme kağıdımızı açtığımız hamurdan biraz daha büyük olacak şekilde keselim.Kıymalı harcımızdan 2 yemek kaşığı kadar alalım, hamurumuzun üzerine elimizle güzel bir şekilde yayalım.Lahmacunumuzu altında pişirme kağıdı ile birlikte ısıttığımız tavaya alalım, altı hafif kızarana kadar tavada pişirelim.Daha sonra lahmacunumuzu fırın telinin üzerine alalım, ızgara ayarında maksimum derece getirdiğimiz fırında yaklaşık 250°C de kenarları kızarmaya başlayıncaya kadar pişirelim.Fırından aldığımız lahmacunların üzerini temiz bir bez ile kapatalım. Böylece biz diğer bezeleri hazırlarken pişen lahmacunlarımız kurumayacaktır.Lahmacunların pişirme süreleri kısa olduğu için biri pişerken diğerini hazırlarsanız sizin için daha kolay olacaktır. Aynı zamanda her lahmacunda aynı pişirme kağıdını kullanabilirsiniz.Tüm lahmacunlarımızı bu şekilde pişirdikten sonra servis edebiliriz. Deneyeceklere afiyet olsun.', 'lahmacun.png'),
//('Pizza', 'Atıştırmalıklar', 70, 'Unu yoğurma kabına alalım ve ortasını havuz şeklinde açalım.Unun ortasına instant maya, şeker, tuz, zeytinyağı ve ılık suyu yavaş yavaş ilave ederek hamurumuzu yoğurmaya başlayalım. İnstant maya yerine yarım paket yaş mayada kullanabilirsiniz.Yumuşak kıvamlı ele yapışmayan bir hamur elde edelim.Toparlanan hamurumuzun üzerini streç film örterek yaklaşık 30 dk kadar mayalanmaya bırakalım.Mayalanan hamurun üzerini açalım ve un serptiğimiz tezgaha hamuru alalım.Elimizle yine toparlayıp havasını aldıktan sonra 2 eşit parçaya bölelim. Eğer ince hamurlu pizza hazırlamak istiyorsanız aynı hamuru 3 parçaya da bölebilirsiniz.Kestiğimiz parçayı beze haline getirerek un serptiğimiz tezgahta merdane yardımıyla açalım. Hafifçe un serperek merdaneye yapışmamasını sağlayabilirsiniz.Açtığımız hamuru pizza tepsisine almadan önce boyutu uygun mu diye kontrol edelim.Açtığımız hamuru unladığımız pizza tepsisine alalım ve elimizle etrafını düzeltelim.Dilerseniz normal fırın tepsisine pişirme kağıdı sererek veya altına mısır unu serperek de hazırlayabilirsiniz.Bir çatal yardımıyla hamurumuzun tüm yüzeyine delikler açalım böylelikle hamur pişerken kabarmayacaktır.Pizza tepsisini önceden ısıttığımız 200° fırına sürerek hamurumuzu 10 dk pişirelim.Hamurumuz pişerken pizzanın sosu için domates sosu, zeytinyağı, kuru fesleğen ve kekiği ekleyerek güzelce karıştıralım.Yarı pişen hamurumuzu fırından alıp hazırladığımız sosu üzerine bolca sürelim. Kenarlarına doğruda güzelce sürersek kenarlarıda daha güzel kızaracaktır.Domates sosunun üzerine bolca mozzarella peyniri rendesi veya kaşar peyniri rendesini yerleştirelim.Üzerine tercihe göre dilimlenmiş sucuk, dilimlenmiş sosis, domates kurusu,dilimlenmiş mantar ve mısır tanelerini ekleyelim.Son olarak pizzamızı tekrar fırına sürelim ve 200° fırında 20 dk daha pişmeye bırakalım.Peynirleri güzel bir şekilde eriyen sucukları sosisleri gayet nefis bir şekilde pişen pizzamız servise hazır. Afiyet olsun :)', 'pizza.png'),
//('Patates Kroket', 'Atıştırmalıklar', 30, 'İlk olarak patateslerimizi haşlayalım.Daha sonra haşladığımız patateslerimizi çift kilitli poşet içerisine alalım, merdane yardımı ile güzelce ezelim. Daha farklı şekillerde de ezebilirsiniz bu şekilde bana pratik ve hızlı geliyor.Taze soğanlarımızı küçük küçük doğrayalım ve patateslerimizin üzerine ekleyelim.Tuz ve karabiberi de ekledikten sonra güzel bir şekilde karıştıralım.Patatesli harcımızdan 1 kaşık kadar alalım, içerisine doğradığımız kaşar peynirinden yerleştirelim ve elimizde yuvarlayarak şekil verelim. Bu aşamada elinizi ıslarsanız patates toplarınıza daha kolay şekil verebilirsiniz.Kızartma tavamıza bol sıvı yağ alalım ve kızdıralım. Yağ ısınırken diğer yandan yumurtamızı çırpalım.Patates toplarımızı ilk önce una daha sonra çırptığımız yumurtaya ve son olarak galeta ununa bulayalım.Kızgın yağın içerisine dikkatlice bırakılım ve çevirerek her yerinin kızarmasını sağlayalım.Kızaran patates toplarımızı peçete üzerine alarak fazla yağını çektirelim, daha sonra servis tabağına alarak sıcak sıcak servis yapabilirsiniz. Afiyet olsun.', 'patateskroket.png'),
//('Kuru Domatesli Peynir Topları', 'Atıştırmalıklar', 5, 'Loru genişçe bir kapta zeytinyağı ile güzelce eziyoruz. Önceden ılık suda 10 dakika kadar beklettiğimiz ve süzdüğümüz kuru domatesleri küçük küçük doğrayıp üzerine ilave ediyoruz. Ardından ceviz içini, çörek otunu, ince ince doğradığımız maydanoz ve dereotunu, baharatları ilave edip karıştırıyoruz. Avuç içinde sıkarak top şekli veriyoruz ve servis ediyoruz.', 'kurudomateslipeynirtoplari.png'),
//('Bruschetta', 'Atıştırmalıklar', 45, 'Ekmeği orta kalınlıkta kesiyoruz ve fırın tepsisinde veya tavada iki taraflı fazla kurutmadan ve karartmadan kızartıyoruz.Sıvı yağı ve rendelenmiş sarımsağı bir kaseye alıp karıştıralım, bu karışımdan sıcak ekmeklerin üzerine bir fırça yardımı ile eşit bir şekilde sürelim.Domatesleri, soğanı ve birkaç fesleğen yapraklarını ince ince doğrayalım, tuzunu ekleyip karıştıralım ve kenara alalım.Mozzarella peynirini dilimlere keselim, kabak ve patlıcanlı yapmak isterseniz ince dilimlere kesip kızartın.Sadece domates dilimleri veya füme somon dilimleri ile servis de yapabilirsiniz.Hazırladığınız malzemelerden ekmeklerin üzerine dilediğiniz şekilde hazırlayabilirsiniz.', 'bruschetta.png'),

//('Tavuk Sote', 'Ana Yemek', 40, 'Tavuk etini kuşbaşı doğrayın.Soğanları yemeklik, biberleri julyen doğrayın, domatesleri de küp küp doğrayın.Kısık ateşte tavukları arada karıştırarak kavurun.Suyunu biraz çektikten sonra soğanları, ince kesilmiş sarımsağı ve sıvı yağını ekleyin.1-2 dk kavurduktan sonra biberleri ilave edin.Biberler de sotelenince domatesi, salçayı, baharatları ve tuzu ekleyip pişirmeye devam edin.Son olarak 1 bardak suyu ekleyin ve etler pişene kadar kapağı kapalı bir şekilde pişirin.', 'tavuksote.png'),
//('Karnıyarık', 'Ana Yemek', 50, 'Patlıcanları çizgili soyup, yarım saat yağ çekmemesi için tuzlu suda bekletin.İyice yıkadıktan sonra suyunu havlu ile çektirin ve az yağda kızartın. 3 adet biberi de yağda kızartın.Daha sonra aynı tavada doğranmış soğanları kavurun, kıymayı ekleyerek bir müddet daha kavurun ve biberleri, sarımsağı ekleyerek 2 dakika daha kavurun.Küp küp doğramış olduğunuz 2 adet domatesi, tuzu, baharatları ekleyerek karıştırın.Üzerine bir çay bardağı su ekleyerek 5 dk kaynatın.Tepsiye patlıcanların ortalarını keserek yerleştirin ve bu kesiklerden patlıcanın içine bastırarak iç malzemesine yer açın ve malzeme ile patlıcanları doldurun.Doldurduğunuz patlıcanların üzerine ortadan ikiye kestiğiniz çeri domatesi ya da 1 adet domatesi eşit büyüklükte olacak şekilde paylaştırın ve kızarttığımız biberlerden birer tane koyun.Ayrı bir yerde 1 kaşık salçayı, 1 su bardağı sıcak suda ezerek patlıcanların aralarına dökün. Kıymalar çıkmasın diye üzerine dökmeyin.Daha sonra 170 derece de ısıttığınız fırına sürerek 20-25 dk pişirin. Dilerseniz bu işlemi pilav tenceresi gibi bir tencerede ocakta yapabilirsiniz. Aynı sürede tencerede de  pişecektir.', 'karniyarik.png'),
//('Kuru Fasulye-Pilav', 'Ana Yemek', 90, 'Kuru Fasulye Yapımı;Kuru fasulyeyi 1 gece önceden ıslatıyoruz. Pişireceğimiz gün haşlıyoruz.Bir tencereye sıvı yağımızı ve kıymamızı alıyoruz ve kavuruyoruz.Doğradığımız kuru soğan ve yeşil biberi de ekleyerek, kavuruyoruz.Üzerine domates ve yarım kaşık salçayı ekleyip, 5 dk kadar pişirip, üzerine haşlanan kuruyu ekliyoruz.Tuz, karabiber ve defne yaprağını da ekleyip, üzerine 2 parmak geçecek kadar sıcak su ekleyip pişiriyoruz.Pilav Yapımı;Pirinçlerimizi pilav yapmadan 1 saat önce ıslatıyoruz.Bir tencereye tereyağını koyup, arpa şehriyelerimizi kavuruyoruz.Üzerine, ıslatıp sonra süzdüğümüz pirinçleri ekliyoruz.Tuzunu ekleyip, 3,5 su bardağı sıcak su koyup kısık ateşte pişiriyoruz.Demlenmeye bırakıp, servis ediyoruz.', 'kurufasulyepilav.png'),
//('Fırında Köfte Patates', 'Ana Yemek', 50, 'Öncelikle köfteler hazırlanır. Bunun için soğan bir kaç parçaya ayrılarak sarımsaklar ve yumurta ile mutfak robotundan geçirilir. İncecik hale gelen soğanlar ve sarımsaklar kıymaya ilave edilir.Galeta unu, baharatlar ve tuzu da eklenerek köfte harcı yoğurulur. Malzemeler iyice özdeşleşince ufak parçalar koparılarak köfteler şekillendirilir.Patates ve köfteler kızartılır. Patatesler dilimlenir. Tavada sıvı yağ kızdırılarak köfteler ve patatesler hafifçe kızartılır. (Patateslerin çok fazla pişmesine gerek yok).Köfte ve patatesler fırın kabına alınarak pişirilir. Bütün köfte ve patatesler kızartılınca fırın kabına alınırlar ve üzerine salçalı sıcak su gezdirilir.Domates dilimleri ve biberlerle süslenen fırın tepsisi fırına sürülür. Domatesler pişinceye dek yaklaşık 25 dk kadar düşük ısıda pişirilir. Afiyet olsun…', 'firindakoftepatates.png'),
//('Fırında Tavuk', 'Ana Yemek', 55, 'Tereyağı, kırmızı toz biber, limon suyu, tuz ve karabiberi bir kapta karıştırın.Tavuğu fırına vereceğiniz tepsiye alın. Hazırladığınız tereyağlı karışım ile tavuğun derisini tamamen ovun.İç kısmına elma dilim kesilmiş soğanla birlikte, defne yaprağı ve bir dal taze biberiye yerleştirin. Dilimlediğiniz patates ve yarım soğanı da tavuğun yanına yerleştirdikten sonra üzerlerine zeytinyağı gezdirin.Önceden ısıtılmış 180 derece fırında yaklaşık 45 dakika pişirdikten sonra porsiyonlayarak servis edin. Sevdiklerinizle paylaşın. Afiyet olsun.', 'firindatavuk.png'),
//('Dolma', 'Ana Yemek', 45, 'Dolmalık biberlerimizi temizleyelim.Soğanları, domatesi küçük küçük doğrayalım.Domatesin kenarlarını biberlerin üstünü kapatmak için kullanacağız o yüzden önce kapatmak için kullanacaklarımızı kesersek daha iyi olur.İçini yemek harcında kullanabiliriz.Bir kaba hazırladığımız soğan, pirinç, salça, maydanoz, domates, karabiber, tuz, nane ve çok az sıvı yağı ekleyip iyice karıştıralım.Daha sonra bu harcı biberlere dolduralım.Harcı doldurduğumuz biberleri, tencereye dizelim.Harcı yaptığımız kabın içine sıcak su koyalım.O artık göz kararı olacak biberlerin yarısına kadar gelecek şekilde kabın içine koyduğumuz suya 1 yemek kaşığı salça ekleyelim ve eritelim.Bu karışımı biberlerin üstüne gelmeyecek şekilde tencereye, biberlerin yarısına gelene kadar dökelim.Kestiğimiz domateslerle biberlerin üstünü kapatalım.Daha sonra biberlerin üstüne çok az sıvı yağ veya zeytinyağı gezdirelim.Kısık ateşte yemeğimizi pişirelim.', 'dolma.png'),
//('Yağlama', 'Ana Yemek', 100, 'Bir kabın içine unu alın ve ortasına bir havuz açın. Su, maya, şeker ve tuzu ilave ederek orta kısmını karıştırın. Ardından hamuru pürüzsüz bir kıvama gelene kadar yoğurun. Gerekirse un veya su ilavesi yaparak hamuru dengeleyin.Üzerini streç film ile kapatarak oda sıcaklığında iki katına çıkana kadar yaklaşık 40 dakika kadar mayalanmaya bırakın. Mayalanan hamurdan eşit küçük bezeler hazırlayın. (yaklaşık 10-12 adet)Hazırladığınız bezeleri yemek tabağı büyüklüğünde açın ve ısıtılmış düz bir tavada arkalı önlü pişirin.Kıymalı harcı için; sos tavasına yağları alın ve kızdırın. Ardından kıymayı ekleyip kavurun.Soğanları da ilave edip yumuşayana kadar pişirin. Üzerine salçayı ve domates püresini ekleyip 1-2 dakika kavurun.Ardından tuz, karabiber ve suyunu da ekleyip orta ateşte, kaynayıp yağı üzerine çıkana kadar pişirin.Tüm yufkaları pişirdikten sonra bir pişmiş yufka, ardından hazırladığınız kıymalı iç, ardından tekrar yufka sıralamasıyla kat çıkın.Tüm iç harç ve yufkalar bittiğinde yağlamayı dörde bölün ve maydanoz serpiştirip, arzuya göre üzerine yoğurt ekleyip servis edin. Afiyet olsun!', 'yaglama.png'),
//('Türlü', 'Ana Yemek', 55, 'Öncelikle bütün sebzeler soyup küp küp doğranır ve kızgın yağda sırayla kızartılır.Diğer yandan kuşbaşı etler tuzlanıp haşlanır.Bütün sebzeler kızardıktan sonra pişmiş etlerle birlikte bi borcamda karıştırılır.Üstüne suyla açtığımız salça sosu gezdirilir.Hazırladığımız karışımı 200 derece fırında 20 dk kadar pişiriyoruz.', 'turlu.png'),
//('Kavurmalı Pilav', 'Ana Yemek', 80, 'Kavurması için; etler bir tencereye alınır, baharatları ilave edilir ve kavrulmaya başlanır.Suyunu çekmeye yakın, 2 bardak sıcak su ilave edilir ve kısık ateşte, etler suyunu çekene kadar pişirilir.Ardından etler sac tavasına alınır, tereyağı ve sıvı yağ eklenir. 5 dk daha kavrulur, ocak kapatılır.Pilavı için; pirinçler yıkanır.3 yemek kaşığı şehriye, sıvı yağ ile kavrulur.Tereyağı ilave edilir. Yıkanan pirinç ilave edilir ve kavrulur. Pirinçler tane tane olana kadar kavrulur. (Püf nokta, kavrulan pirinç tane tane olur lapa olmaz)Kavrulan pirincimize 4 bardak sıcak su (tavuk/et) ilave edilip, kısık ateşte pişirilir.Sunumu için; yuvarlak kek kalıbına önce kavurma, ardından pilav konulur ve üzerine bastırılır.Servis tabağına ters çevrilir ve servis edilir.', 'kavurmalipilav.png'),
//('Tepsi Kebabı', 'Ana Yemek', 60, 'Tepsi kebabı için bir kapta veya pişireceğiniz tepside kıyma, soğan, maydanoz, sivri biber, sarımsak, kimyon, tuz, karabiber ve pul biberi karıştırıp iyice yoğurun.Malzemeler birbirine iyice karışınca, yuvarlak bir fırın tepsisine kıymalı karışımı iyice yayın ve ellerinizle üzerine bastırarak düzleştirin.Bıçak yardımıyla 8 dilim olacak şekilde dilimleyin. Eritilmiş tereyağını kebabın üzerine dökün ve fırça yardımıyla her yerine gelecek şekilde yayın.Biber salçası ile suyu karıştırın ve karışımı üzerine dökün.Boydan ikiye böldüğünüz biberleri ve dilimlediğiniz domatesleri üzerine güzelce dizin.190 derece fırında 40 dakika pişirin ve tepsi kebabını sıcak servis edin. Afiyetler olsun!', 'tepsikebabi.png'),
//('Sulu Köfte', 'Ana Yemek', 60, 'İlk olarak yemeğimizin köftelerini hazırlayalım. Kıymanın üzerine bulgur, sarımsak, baharatlar ve biraz da tuz ekleyerek iyice yoğuralım. Vaktiniz varsa üzerini streçleyerek 15 dakika kadar buzdolabında bekletebilirsiniz.Ufak ufak yuvarladığımız köfteleri içerisine un serptiğimiz kaba alarak una bulanmalarını sağlayalım.Soğanları doğrayalım ve sıvı yağda soğanlar pembeleşinceye kadar kavuralım.Domates salçasını ilave ederek kavuralım.Küp küp doğramış olduğunuz patatesi ilave ederek 1-2 dakika kadar daha kavuralım.Patateslerin üzerini 2 parmak geçecek kadar sıcak su ilave edelim.Yemek kaynadıktan sonra köfteleri ilave ederek, tuz ve baharatını ilave edelim.Su miktarını kontrol ederek yemeğimizi kaynadıktan sonra kısık ateşte pişmeye bırakalım. (Yemek pişene kadar zaman zaman suyunu kontrol ederek gerekirse ekleyelim.)Pişen yemeğimiz servise hazır. Afiyet olsun.', 'sulukofte.png');

//INSERT INTO tarifrehberidatabase.dbo.MalzemelerTablosu (MalzemeAdi, ToplamMiktar, MalzemeBirim, BirimFiyat) VALUES
//('Su', 100, 'litre', 0),
//('Sıcak Su', 100, 'litre', 0),
//('Un', 10, 'kilogram', 42.95),
//('Süt', 6, 'litre', 42),
//('Krema', 4, 'litre', 49.95),
//('Sıvıyağ', 6, 'litre', 64.50),
//('Tereyağ', 5, 'kilogram', 450.0),
//('Tuz', 1000, 'gram', 23.95),
//('Pul Biber', 240, 'gram', 56.95),
//('Kırmızı Toz Biber', 240, 'gram', 60.95),
//('Sumak', 140, 'gram', 56.95),
//('Kuru nane', 240, 'gram', 35.95),
//('Karabiber', 240, 'gram', 79.95),
//('Tarçın', 150, 'gram', 176.5),
//('Kekik', 240, 'gram', 24.0),
//('Kimyon', 240, 'gram', 62.0),
//('Kuru Fesleğen', 240, 'gram', 100.0),
//('Çörekotu', 240, 'gram', 60.0),
//('Dereotu', 240, 'gram', 50.0),
//('Mantar', 5, 'kilogram', 65.0),
//('Kuru Soğan', 2, 'kilogram', 15.0),
//('Nane', 240, 'gram', 61.0),
//('Maydanoz', 1000, 'gram', 15.0),
//('Kabak', 3, 'kilogram', 60.0),
//('Patates', 4, 'kilogram', 10.0),
//('Havuç', 1, 'kilogram', 8.0),
//('Defne Yaprağı', 100, 'gram', 30.0),
//('Sarımsak', 1, 'kilogram', 50.0),
//('Limon', 3, 'kilogram', 34.0),
//('Domates', 3, 'kilogram', 50.0),
//('Yeşil Biber', 2, 'kilogram', 65.0),
//('Salatalık', 5, 'kilogram', 69.0),
//('Kıvırcık', 2, 'kilogram', 42.95),
//('Mısır', 3000, 'gram', 29.50),
//('Mor Lahana', 2, 'kilogram', 29.50),
//('Turp', 1, 'kilogram', 39.90),
//('Taze Soğan', 1000, 'gram', 27.0),
//('Bezelye', 2, 'kilogram', 49.95),
//('Roka', 1000, 'gram', 19.90),
//('Çeri Domates', 5, 'kilogram', 45.0),
//('Kırmızı Kapya Biber', 2, 'kilogram', 34.90),
//('Biberiye', 100, 'gram', 65.0),
//('Dolma Biberi', 3, 'kilogram', 70.0),
//('Patlıcan', 3, 'kilogram', 30.0),
//('Fesleğen', 500, 'gram', 32.0),
//('Marul', 3, 'kilogram', 40.50),
//('Kuzu Gerdan Eti', 2, 'kilogram', 459.95),
//('Pastırma', 1, 'kilogram', 325.0),
//('Sucuk', 1, 'kilogram', 289.0),
//('Sosis', 1, 'kilogram', 155.0),
//('Kıyma', 2, 'kilogram', 450.0),
//('Tavuk', 2, 'kilogram', 289.90),
//('Kuşbaşı Et', 3, 'kilogram', 789.0),
//('Somon', 1, 'kilogram', 250.0),
//('Tavuk Göğsü', 1, 'kilogram', 289.0),
//('Kırmızı Mercimek', 2, 'kilogram', 65.0),
//('Pirinç', 2, 'kilogram', 162.0),
//('Bulgur', 2, 'kilogram', 42.0),
//('Kuru Fasulye', 2, 'kilogram', 132.0),
//('Şehriye', 1, 'kilogram', 22.0),
//('Buğday', 1, 'kilogram', 45.95),
//('Nohut', 2, 'kilogram', 25.0),
//('Tarhana', 2, 'kilogram', 51.75),
//('Süzme Yoğurt', 1, 'kilogram', 78.95),
//('Yoğurt', 1, 'kilogram', 48.50),
//('Biber Salçası', 1, 'kilogram', 114.0),
//('Domates Salçası', 1, 'kilogram', 42.0),
//('Yumurta', 50, 'adet', 5.0),
//('Zeytinyağı', 2, 'litre', 336.0),
//('Kornişon Turşu', 1000, 'gram', 73.0),
//('Mayonez', 1, 'kilogram', 128.0),
//('Nar Ekşisi', 1, 'kilogram', 161.0),
//('Nar', 1, 'kilogram', 40.0),
//('Boncuk Makarna', 2, 'kilogram', 15.0),
//('Garnitür Konserve', 2, 'kilogram', 25.0),
//('Şeker', 5, 'kilogram', 15.0),
//('Buğday Nişastası', 5, 'kilogram', 30.0),
//('Vanilya', 200, 'gram', 150.0),
//('İrmik', 1, 'kilogram', 18.0),
//('Kabartma Tozu', 1000, 'gram', 40.0),
//('Pudra Şekeri', 4, 'kilogram', 34.90),
//('Fındık', 5, 'kilogram', 129.0),
//('Kedidili Bisküvi', 3000, 'gram', 100.0),
//('Nişasta', 3, 'kilogram', 39.50),
//('Kremşanti', 500, 'gram', 33.0),
//('Çikolata Sosu', 2, 'kilogram', 76.0),
//('Çikolata Parçacığı', 500, 'gram', 80.0),
//('Bitter Çikolata', 1, 'kilogram', 100.0),
//('Çilek', 3, 'kilogram', 50.0),
//('Bebe Bisküvisi', 3000, 'gram', 55.0),
//('Galeta Unu', 3000, 'gram', 26.90),
//('Hazır Yufka', 20, 'adet', 30.0),
//('Beyaz Peynir', 1, 'kilogram', 209.0),
//('Kaşar Peyniri', 1, 'kilogram', 229.0),
//('Mozzarella Peyniri', 1, 'kilogram', 220.0),
//('Lor Peyniri', 1, 'kilogram', 65.0),
//('Maya', 1000, 'gram', 20.0),
//('Yaş Maya', 500, 'gram', 7.75),
//('Ekmek', 400, 'gram', 10.0),
//('Ceviz', 500, 'gram', 72.50),
//('Pandispanya Keki', 500, 'gram', 173.95),
//('Labne Peyniri', 300, 'gram', 47.50),
//('Kahve', 300, 'gram', 54.50),
//('Kakao', 100, 'gram', 62.90);

//INSERT INTO tarifrehberidatabase.dbo.TarifMalzemeIliskisi (TarifID, MalzemeID, MalzemeMiktar) VALUES
//(1, 56, 0.4),    -- 2 su bardağı kırmızı mercimek (~400 gram)
//(1, 21, 1),      -- 1 adet soğan (~100 gram)
//(1, 3, 0.03),   -- 2 yemek kaşığı un (~30 gram)
//(1, 26, 0.1),    -- 1 adet havuç (~100 gram)
//(1, 67, 0.02), -- Yarım yemek kaşığı biber/domates salçası (~20 gram)
//(1, 8, 5),      -- 1 tatlı kaşığı tuz (~5 gram)
//(1, 13, 0.5),    -- Yarım çay kaşığı karabiber (~0.5 gram)
//(1, 16, 1),      -- 1 çay kaşığı kimyon (~1 gram)
//(1, 2, 2),      -- 2 litre sıcak su
//(1, 6, 0.075),  -- 5 yemek kaşığı sıvı yağ (~75 ml)
//(1, 7, 0.03),   -- 2 yemek kaşığı tereyağı (~30 gram)
//(1, 10, 1),     -- 1 tatlı kaşığı kırmızı toz biber (~1 gram)

//(2, 63, 0.06),   -- 3 yemek kaşığı ev tarhanası (~60 gram)
//(2, 12, 0.01),   -- 1 yemek kaşığı nane (~10 gram)
//(2, 6, 0.03),    -- 2 yemek kaşığı sıvı yağ (~30 ml)
//(2, 67, 0.02),   -- 1 yemek kaşığı salça (~20 gram)
//(2, 1, 1.2),    -- 6 su bardağı su (~1.2 litre)
//(2, 9, 0.005),  -- Kırmızı pul biber (~0.5 gram, isteğe bağlı miktar)
//(2, 13, 0.5),     -- Karabiber (~0.5 gram, isteğe bağlı)
//(2, 8, 0.005),       -- Tuz (~5 gram)

//--
//(3, 30, 0.500),   -- 5 adet olgun domates (≈ 500 gram = 0.500 kg, ortalama)
//(3, 7, 0.030),   -- 2 yemek kaşığı tereyağı (≈ 30 gram = 0.030 kg)
//(3, 3, 0.030),   -- 3 yemek kaşığı un (≈ 30 gram = 0.030 kg)
//(3, 2, 1.000),   -- 1 litre sıcak su
//(3, 4, 0.250),   -- 1 su bardağı süt (≈ 250 gram = 0.250 kg)
//(3, 94, 0.100),   -- Rendelenmiş taze kaşar (≈ 100 gram = 0.100 kg, tahmini)

//(4, 52, 0.500),   -- 2 adet haşlanmış tavuk budu (≈ 500 gram = 0.500 kg, ortalama)
//(4, 60, 0.060),   -- 3 yemek kaşığı şehriye (≈ 60 gram = 0.060 kg)
//(4, 69, 0.030),   -- 2 yemek kaşığı zeytinyağ (≈ 30 gram = 0.030 kg)
//(4, 65, 0.030),   -- 2 yemek kaşığı yoğurt (≈ 30 gram = 0.030 kg)
//(4, 3, 0.015),   -- 1.5 yemek kaşığı un (≈ 15 gram = 0.015 kg)
//(4, 68, 0.050),   -- 1 adet yumurtanın sarısı (≈ 50 gram = 0.050 kg)
//(4, 28, 0.010),   -- 2 diş rendelenmiş sarımsak (≈ 10 gram = 0.010 kg)
//(4, 29, 0.025),   -- 1/2 (yarım) adet limon (≈ 25 gram = 0.025 kg, tahmini)
//(4, 13, 0.005),   -- 1 çay kaşığı karabiber (≈ 5 gram = 0.005 kg)
//(4, 8, 0.020),  -- 1 tatlı kaşığı tuz (≈ 20 gram = 0.020 kg)
//(4, 1, 2.000),  -- 8-9 su bardağı su (≈ 2 litre = 2.000 kg)

//(5, 57, 0.020),   -- 1 çay bardağı pirinç (≈ 20 gram = 0.020 kg)
//(5, 1, 0.600),   -- 3 su bardağı su (≈ 600 gram = 0.600 kg)
//(5, 2, 0.600),   -- 3 su bardağı sıcak su (tavuk suyu veya kemik suyu) (≈ 600 gram = 0.600 kg)
//(5, 8, 0.010),   -- Tuz (≈ 10 gram = 0.010 kg, tahmini)
//(5, 68, 0.050),   -- 1 adet yumurta sarısı (≈ 50 gram = 0.050 kg)
//(5, 65, 0.375),   -- 1,5 su bardağı yoğurt (≈ 375 gram = 0.375 kg)
//(5, 3, 0.015),   -- 1 yemek kaşığı un (≈ 15 gram = 0.015 kg)
//(5, 7, 0.030),   -- 2 yemek kaşığı tereyağı (≈ 30 gram = 0.030 kg)
//(5, 12, 0.010),   -- 1 yemek kaşığı kuru nane (≈ 10 gram = 0.010 kg)

//(6, 47, 0.500),   -- 500 g kuzu gerdan eti
//(6, 1, 1.700),   -- 1,5 litre su
//(6, 65, 0.050),   -- 5 yemek kaşığı yoğurt (≈ 50 gram = 0.050 kg)
//(6, 3, 0.030),   -- 3 yemek kaşığı un (≈ 30 gram = 0.030 kg)
//(6, 68, 0.050),   -- 1 yumurta sarısı (≈ 50 gram = 0.050 kg)
//(6, 29, 0.025),   -- Yarım limon suyu (≈ 25 gram = 0.025 kg, tahmini)
//--(6, 1, 0.250),   -- 1 su bardağı su (≈ 250 gram = 0.250 kg)
//(6, 9, 0.010),   -- Pul biber (≈ 10 gram = 0.010 kg)
//(6, 7, 0.045),   -- 2-3 yemek kaşığı tereyağı (≈ 45 gram = 0.045 kg)

//(7, 56, 0.200),   -- 1 su bardağı kırmızı mercimek (≈ 200 gram = 0.200 kg)
//(7, 57, 0.020),   -- 1 tatlı kaşığı pirinç (≈ 20 gram = 0.020 kg)
//(7, 58, 0.020),   -- 1 tatlı kaşığı bulgur (≈ 20 gram = 0.020 kg)
//(7, 9, 0.010),   -- 2 çay kaşığı pul biber (≈ 10 gram = 0.010 kg)
//(7, 12, 0.010),   -- 1 yemek kaşığı nane (≈ 10 gram = 0.010 kg)
//(7, 28, 0.020),   -- 2 diş sarımsak (≈ 20 gram = 0.020 kg, ortalama)
//(7, 37, 0.150),   -- 1 orta boy soğan (≈ 150 gram = 0.150 kg, ortalama)
//(7, 66, 0.015),   -- 1 yemek kaşığı biber salçası (≈ 15 gram = 0.015 kg)
//(7, 7, 0.020),   -- 1 yemek kaşığı tereyağı (≈ 20 gram = 0.020 kg)
//(7, 2, 2.000),  -- 2 litreye yakın sıcak su (≈ 2000 gram = 2.000 kg)

//(8, 24, 0.500),   -- 2 adet kabak (≈ 500 gram = 0.500 kg, tahmini)
//(8, 26, 0.600),   -- 3 adet havuç (≈ 600 gram = 0.600 kg, tahmini)
//(8, 25, 0.600),   -- 3 adet patates (≈ 600 gram = 0.600 kg, tahmini)
//(8, 27, 0.010),   -- 2-3 adet defne yaprağı (≈ 10 gram = 0.010 kg, tahmini)
//(8, 4, 0.500),   -- 2 su bardağı süt (≈ 500 gram = 0.500 kg)
//(8, 7, 0.030),   -- 2 yemek kaşığı tereyağı (≈ 30 gram = 0.030 kg)
//(8, 6, 0.010),   -- Yarım çay bardağı sıvı yağ (≈ 10 gram = 0.010 kg)
//(8, 3, 0.030),   -- 1 yemek kaşığı un (≈ 30 gram = 0.030 kg)
//(8, 8, 0.020),   -- 2 tatlı kaşığı tuz (≈ 20 gram = 0.020 kg)
//(8, 10, 0.005),  -- 1 tatlı kaşığı kırmızı toz biber (≈ 5 gram = 0.005 kg)
//(8, 2, 2.500),  -- 2,5 litre sıcak su (≈ 2.500 kg)
//(8, 19, 0.010),   -- 1 avuç dereotu (isteğe bağlı) (≈ 10 gram = 0.010 kg)

//(9, 20, 0.400),   -- 400 gram mantar
//(9, 37, 0.100),   -- 1 adet orta boy kuru soğan (≈ 100 gram)
//(9, 3, 0.020),   -- 1-2 yemek kaşığı un (≈ 20 gram, ortalama)
//(9, 4, 0.150),   -- 1,5 su bardağı süt (≈ 150 gram)
//(9, 5, 0.200),   -- 200 ml sıvı krema (≈ 200 gram)
//(9, 6, 0.045),   -- 3 yemek kaşığı sıvı yağ (≈ 45 gram)
//(9, 7, 0.015),   -- 1 yemek kaşığı tereyağı (≈ 15 gram)
//(9, 8, 0.010),   -- Tuz (≈ 10 gram, ortalama)
//(9, 13, 0.010),   -- Karabiber (≈ 10 gram, ortalama)
//(9, 23, 0.005),  -- 1 tutam taze maydanoz (≈ 5 gram, ortalama)
//(9, 1, 3.500),  -- 3,5 su bardağı oda sıcaklığında su (≈ 3.500 gram)

//(10, 61, 0.200),   -- 1 su bardağı buğday (≈ 200 gram)
//(10, 62, 0.200),   -- 1 su bardağı nohut (≈ 200 gram)
//(10, 64, 0.250),   -- 250 gram süzme yoğurt
//(10, 65, 0.250),   -- 250 gram yoğurt
//(10, 1, 0.250),   -- 1 su bardağı su (≈ 250 gram)
//(10, 8, 0.005),   -- 1 çay kaşığı tuz (≈ 5 gram)
//(10, 19, 0.010),   -- 1 tatlı kaşığı dereotu (≈ 10 gram, ortalama)

//(11, 30, 4.000),   -- 4 adet domates
//(11, 21, 1.000),   -- 1 adet soğan
//(11, 8, 0.005),   -- 1 çay kaşığı tuz (≈ 5 gram = 0.005 kg)
//(11, 31, 2.000),   -- 2 adet yeşil biber
//(11, 32, 1.000),   -- 1 adet salatalık
//(11, 23, 0.050),   -- Maydanoz (yaklaşık 50 gram = 0.050 kg)
//(11, 29, 0.030),   -- Limon suyu (yaklaşık 30 ml = 0.030 kg)
//(11, 69, 0.050),   -- Zeytinyağı (yaklaşık 50 ml = 0.050 kg)

//(12, 33, 0.150),   -- 5-6 yaprak kıvırcık (yaklaşık 150 gram = 0.150 kg)
//(12, 26, 3.000),   -- 3 adet havuç (yaklaşık 300 gram = 0.300 kg)
//(12, 34, 0.220),   -- 1 kutu mısır (220 gr = 0.220 kg)
//(12, 35, 0.250),   -- Yarım orta boy mor lahana (yaklaşık 250 gram = 0.250 kg)
//(12, 23, 0.050),   -- Yarım demet maydanoz (yaklaşık 50 gram = 0.050 kg)
//(12, 36, 1.000),   -- 1 adet turp (yaklaşık 100 gram = 0.100 kg)
//(12, 69, 0.015),   -- Yarım çay bardağı zeytinyağı (yaklaşık 15 ml = 0.015 kg)
//(12, 29, 0.020),   -- 1 adet limon (yaklaşık 20 gram = 0.020 kg)
//(12, 8, 0.005),   -- 1 çay kaşığı tuz (≈ 5 gram = 0.005 kg)

//(13, 1, 1.000),   -- 1-2 litre su (haşlamak için)
//(13, 25, 0.800),   -- 10 adet taze patates (yaklaşık 800 gram = 0.800 kg)
//(13, 37, 0.100),   -- 4 dal taze soğan (yaklaşık 100 gram = 0.100 kg)
//(13, 23, 0.050),   -- 1/2 demet maydanoz (yaklaşık 50 gram = 0.050 kg)
//(13, 8, 0.010),   -- 2 çay kaşığı tuz (≈ 10 gram = 0.010 kg)
//(13, 11, 0.005),   -- 1 tatlı kaşığı sumak (≈ 5 gram = 0.005 kg)
//(13, 13, 0.005),   -- 1 çay kaşığı karabiber (≈ 5 gram = 0.005 kg)
//(13, 29, 0.030),   -- 1 adet limon suyu (yaklaşık 30 ml = 0.030 kg)
//(13, 69, 0.010),   -- 1/3 çay bardağı zeytinyağı (yaklaşık 10 ml = 0.010 kg)

//(14, 25, 0.300),   -- 3 adet patates (yaklaşık 300 gram = 0.300 kg)
//(14, 26, 0.200),   -- 2 adet havuç (yaklaşık 200 gram = 0.200 kg)
//(14, 38, 0.100),   -- 1 su bardağı bezelye (ayıklanmış) (≈ 100 gram = 0.100 kg)
//(14, 70, 0.300),   -- 6 adet kornişon turşu (yaklaşık 300 gram = 0.300 kg)
//(14, 71, 0.050),   -- 5 yemek kaşığı mayonez (yaklaşık 50 gram = 0.050 kg)
//(14, 65, 0.050),   -- 5 yemek kaşığı yoğurt (yaklaşık 50 gram = 0.050 kg)
//(14, 8, 0.010),   -- 1 tatlı kaşığı tuz (≈ 10 gram = 0.010 kg)
//(14, 13, 0.005),   -- 1/2 çay kaşığı karabiber (≈ 5 gram = 0.005 kg)

//(15, 35, 0.300),   -- Yarım orta boy mor lahana (≈ 300 gram = 0.300 kg, tahmini)
//(15, 6, 0.050),   -- Sıvı yağ (≈ 50 ml = 0.050 L)
//(15, 65, 0.125),   -- 5 yemek kaşığı yoğurt (≈ 125 gram = 0.125 kg)
//(15, 71, 0.045),   -- 3 yemek kaşığı mayonez (≈ 45 gram = 0.045 kg)
//(15, 8, 0.010),   -- Tuz (≈ 10 gram = 0.010 kg)
//(15, 28, 0.005),   -- 1 diş sarımsak (≈ 5 gram = 0.005 kg)

//(16, 39, 0.025),   -- Yarım demet roka (≈ 25 gram = 0.025 kg, tahmini)
//(16, 40, 0.150),   -- 5 adet çeri domates (≈ 150 gram = 0.150 kg, tahmini)
//(16, 21, 0.050),   -- Yarım orta boy kuru soğan (≈ 50 gram = 0.050 kg, tahmini)
//(16, 100, 0.030),   -- 6 adet ceviz (≈ 30 gram = 0.030 kg, tahmini)
//(16, 11, 0.010),   -- 1 tatlı kaşığı sumak (≈ 10 gram = 0.010 kg)
//(16, 8, 0.005),   -- 1 çay kaşığı tuz (≈ 5 gram = 0.005 kg)
//(16, 69, 0.030),   -- 2 yemek kaşığı dolusu zeytinyağı (≈ 30 gram = 0.030 kg)
//(16, 29, 0.025),   -- Yarım limon (≈ 25 gram = 0.025 kg, tahmini)

//(17, 24, 0.450),   -- 3 adet kabak (≈ 450 gram = 0.450 kg, tahmini)
//(17, 34, 0.300),   -- 1 kutu mısır (≈ 300 gram = 0.300 kg, tahmini)
//(17, 100, 0.025),   -- Yarım çay bardağı kırılmış ceviz (≈ 25 gram = 0.025 kg, isteğe bağlı)
//(17, 19, 0.025),   -- Yarım demet dereotu (≈ 25 gram = 0.025 kg, tahmini)
//(17, 65, 0.300),   -- 1,5 su bardağı yoğurt (≈ 300 gram = 0.300 kg)
//(17, 28, 0.010),   -- 2 diş ezilmiş sarımsak (≈ 10 gram = 0.010 kg, tahmini)
//(17, 6, 0.020),   -- 2 yemek kaşığı sıvı yağ (≈ 20 gram = 0.020 kg)
//(17, 8, 0.005),   -- Tuz (≈ 5 gram = 0.005 kg)
//(17, 69, 0.020),   -- Zeytinyağı (üzeri için, tahmini)
//(17, 9, 0.005),  -- 1 çay kaşığı pul biber (≈ 5 gram = 0.005 kg)

//(18, 58, 0.250),   -- 1 su bardağı ince kısırlık bulgur (≈ 250 gram = 0.250 kg)
//(18, 23, 0.025),   -- Yarım demet maydanoz (≈ 25 gram = 0.025 kg, tahmini)
//(18, 22, 0.025),   -- Yarım demet taze nane (≈ 25 gram = 0.025 kg, tahmini)
//(18, 30, 0.150),   -- 1 adet domates (≈ 150 gram = 0.150 kg)
//(18, 37, 0.050),   -- 3-4 dal yeşil soğan (≈ 50 gram = 0.050 kg, tahmini)
//(18, 72, 0.030),   -- 2 yemek kaşığı nar ekşisi (≈ 30 gram = 0.030 kg, tahmini)
//(18, 69, 0.030),   -- 3 yemek kaşığı zeytinyağı (≈ 30 gram = 0.030 kg)
//(18, 8, 0.005),   -- 1 çay kaşığı tuz (≈ 5 gram = 0.005 kg)
//(18, 29, 0.050),   -- 1 adet limonun suyu (≈ 50 gram = 0.050 kg, tahmini)
//(18, 2, 0.250),  -- Sıcak su (≈ 250 gram = 0.250 kg, tahmini)
//(18, 73, 0.200),  -- 1 nar (≈ 200 gram = 0.200 kg, tahmini)

//(19, 30, 3),        -- 3 adet domates
//(19, 31, 1),        -- 1 adet yeşil biber
//(19, 21, 1),        -- 1 adet kuru soğan
//(19, 37, 4),        -- 3-4 dal taze soğan (ortalama 4 dal alındı)
//(19, 23, 0.100),    -- 1 demet maydanoz (ortalama 100 gram = 0.100 kg)
//(19, 100, 0.200),    -- 2 avuç iri kırılmış ceviz (ortalama 200 gram = 0.200 kg)
//(19, 69, 0.050),    -- Zeytinyağı (yaklaşık 50 ml = 50 gram = 0.050 kg)
//(19, 72, 0.050),    -- Nar ekşisi (yaklaşık 50 ml = 50 gram = 0.050 kg)
//(19, 11, 0.010),    -- Sumak (yaklaşık 10 gram = 0.010 kg)
//(19, 8, 0.010),   -- Tuz (yaklaşık 10 gram = 0.010 kg)

//(20, 74, 0.250),   -- Yarım paket boncuk makarna (250 gr = 0.250 kg)
//(20, 75, 0.340),   -- 1 kavanoz hazır garnitür (340 gr = 0.340 kg)
//(20, 70, 0.008),   -- 8 adet kornişon turşu (≈ 8 gram x 8 = 64 gram = 0.064 kg, tahmini)
//(20, 65, 0.400),   -- 2 su bardağı yoğurt (≈ 400 gram = 0.400 kg)
//(20, 71, 0.045),   -- 3 yemek kaşığı mayonez (≈ 15 gram x 3 = 45 gram = 0.045 kg, tahmini)
//(20, 8, 0.015),   -- 1 çay kaşığı tuz (≈ 5 gram = 0.005 kg)
//(20, 28, 0.010),   -- 1 diş sarımsak (≈ 10 gram = 0.010 kg, tahmini)
//(20, 2, 2.000),    -- Sıcak su (miktarı belirtilmediği için NULL)
//--(20, 8, 0.010),   -- 1 tatlı kaşığı tuz (makarna haşlama için) (≈ 10 gram = 0.010 kg)

//(21, 4, 1.125),   -- 1 litre süt
//(21, 76, 0.200),   -- 1 su bardağı şeker (≈ 200 gram = 0.200 kg)
//(21, 57, 0.075),   -- Yarım su bardağı pirinç (≈ 75 gram = 0.075 kg)
//(21, 77, 0.045),   -- 3 yemek kaşığı buğday nişastası (≈ 45 gram = 0.045 kg)
//(21, 78, 0.010),   -- 1 paket vanilya (≈ 10 gram = 0.010 kg)
//(21, 1, 0.500),   -- 2 su bardağı su (≈ 500 gram = 0.500 kg)
//--(21, 4, 0.125),  -- Yarım su bardağı süt (nişastayı açmak için) (≈ 125 gram = 0.125 kg)

//(22, 4, 1.500),   -- 6 su bardağı süt (≈ 1500 gram = 1.500 kg)
//(22, 84, 0.030),   -- 2 yemek kaşığı nişasta (≈ 30 gram = 0.030 kg)
//(22, 3, 0.120),   -- 1 su bardağı un (≈ 120 gram = 0.120 kg)
//(22, 76, 0.200),   -- 1 su bardağı şeker (≈ 200 gram = 0.200 kg)
//(22, 7, 0.014),   -- 1 yemek kaşığı tereyağı (≈ 14 gram = 0.014 kg)
//(22, 78, 0.010),  -- 1 paket vanilya (≈ 10 gram = 0.010 kg)

//(23, 68, 0.240),   -- 4 adet yumurta (≈ 240 gram = 0.240 kg)
//(23, 76, 0.900),   -- 4,5 su bardağı toz şeker (≈ 200 gram = 0.200 kg)
//(23, 6, 0.240),   -- 1 su bardağı sıvı yağ (≈ 240 gram = 0.240 kg)
//(23, 65, 0.250),   -- 1 su bardağı yoğurt (≈ 250 gram = 0.250 kg)
//(23, 79, 0.500),   -- 2,5 su bardağı irmik (≈ 500 gram = 0.500 kg)
//(23, 78, 0.010),   -- 1 paket vanilya (≈ 10 gram = 0.010 kg)
//(23, 80, 0.010),   -- 1 paket kabartma tozu (≈ 10 gram = 0.010 kg)
//(23, 1, 1.000),   -- 4 su bardağı su (≈ 1000 gram = 1.000 kg, şerbet için)
//(23, 29, 0.010), -- Bir kaç damla limon suyu

//(24, 101, 1.000),    -- 1 adet hazır pandispanya keki
//(24, 4, 2.500),    -- 2.5 su bardağı süt (≈ 2.5 litre = 2.500 kg)
//(24, 76, 0.075),    -- 3 yemek kaşığı toz şeker (≈ 25 gram = 0.075 kg)
//(24, 3, 0.045),    -- 3 yemek kaşığı un (≈ 45 gram = 0.045 kg)
//(24, 68, 0.050),    -- 1 adet yumurta (≈ 50 gram = 0.050 kg)
//(24, 102, 0.200),    -- 200 gram labne peyniri (≈ 0.200 kg)
//(24, 2, 0.100),    -- 1/2 su bardağı sıcak su (≈ 100 gram = 0.100 kg)
//(24, 103, 0.015),    -- 3'ü bir arada hazır kahve (≈ 15 gram = 0.015 kg)
//(24, 104, 0.010),    -- Kakao (≈ 10 gram = 0.010 kg)

//(25, 7, 0.125),   -- 125 gram oda sıcaklığında tereyağı
//(25, 81, 0.050),   -- Yarım su bardağı pudra şekeri (≈ 50 gram = 0.050 kg)
//(25, 79, 0.045),   -- 3 silme yemek kaşığı irmik (≈ 45 gram = 0.045 kg)
//(25, 68, 0.050),   -- 1 adet yumurta (≈ 50 gram = 0.050 kg)
//(25, 3, 0.240),   -- 2 su bardağı un (≈ 240 gram = 0.240 kg)
//(25, 78, 0.010),   -- 1 paket vanilya (≈ 10 gram = 0.010 kg)
//(25, 80, 0.005),   -- 1 çay kaşığı silme kabartma tozu (≈ 5 gram = 0.005 kg)
//(25, 82, 0.025),   -- Yarım çay bardağı fındık (≈ 25 gram = 0.025 kg, üzeri için)
//(25, 76, 0.400),   -- 2 su bardağı şeker (≈ 400 gram = 0.400 kg, şerbet için)
//(25, 1, 0.600),  -- 3 su bardağı su (≈ 600 gram = 0.600 kg, şerbet için)
//(25, 29, 0.005), -- 4-5 damla limon suyu

//(26, 83, 0.015),   -- 15 adet kedidili bisküvi (adedi kg cinsine çevirmek uygun değil, genelde pişirme için birim kullanılmaz)
//(26, 4, 1.700),   -- 1,7 litre süt
//(26, 3, 0.120),   -- 1 su bardağı un (≈ 120 gram = 0.120 kg)
//(26, 84, 0.060),   -- Yarım su bardağı nişasta (≈ 60 gram = 0.060 kg)
//(26, 68, 0.120),   -- 2 yumurta sarısı (≈ 120 gram = 0.120 kg, ortalama)
//(26, 76, 0.200),   -- 1 su bardağı şeker (≈ 200)
//(26, 78, 0.010),   -- 1 paket vanilya (≈ 10 gram = 0.010 kg)
//(26, 8, 0.010),   -- 2 poşet krem şanti (≈ 10 gram x 2 = 20 gram = 0.020 kg)
//(26, 11, 0.070), -- 70 gram çikolata parçacığı

//(27, 68, 0.360),   -- 6 adet yumurta (≈ 360 gram = 0.360 kg, ortalama)
//(27, 4, 1.000),   -- 1 litre süt
//(27, 76, 0.300),   -- 1 su bardağından 1 parmak eksik şeker (≈ 100 gram = 0.100 kg, tahmini)
//(27, 78, 0.010),   -- 1 paket vanilya (≈ 10 gram = 0.010 kg)

//(28, 88, 0.300),   -- 300 gram bitter çikolata
//(28, 68, 0.180),   -- 3 adet yumurta (≈ 180 gram = 0.180 kg, ortalama)
//(28, 7, 0.150),   -- 150 gram tereyağı (≈ 150 gram = 0.150 kg)
//(28, 76, 0.200),   -- 1 su bardağı toz şeker (≈ 200 gram = 0.200 kg)
//(28, 3, 0.120),   -- 1 su bardağı un (≈ 120 gram = 0.120 kg)
//(28, 78, 0.010),  -- 1 paket vanilya (≈ 10 gram = 0.010 kg)

//(29, 7, 0.150),   -- 150 gram margarin veya tereyağı (≈ 150 gram = 0.150 kg)
//(29, 6, 0.050),   -- Yarım çay bardağı sıvı yağ (≈ 50 ml = 0.050 L)
//(29, 68, 0.060),   -- 1 adet yumurta (≈ 60 gram = 0.060 kg)
//(29, 3, 0.120),   -- 1 su bardağı un (≈ 120 gram = 0.120 kg)
//(29, 84, 0.450),   -- 3 su bardağı nişasta (≈ 450 gram = 0.450 kg)
//(29, 81, 0.120),   -- 1 su bardağı pudra şekeri (≈ 120 gram = 0.120 kg)
//(29, 80, 0.012),   -- 1 paket kabartma tozu (≈ 12 gram = 0.012 kg)
//(29, 78, 0.010),  -- 1 paket vanilya (≈ 10 gram = 0.010 kg)

//(30, 7, 0.125),  -- 125 gram tereyağı = 0.125 kg
//(30, 3, 0.125),  -- 1 su bardağı un ≈ 125 gram = 0.125 kg
//(30, 76, 0.300),  -- 1.5 su bardağı şeker ≈ 300 gram = 0.300 kg
//(30, 4, 1.000),  -- 1 lt süt = 1.000 L
//(30, 78, 0.010),   -- 1 paket vanilya ≈ 10 gram = 0.010 kg
//(30, 14, 0.010),   -- Tarçın (1 tatlı kaşığı) ≈ 5 gram = 0.005 kg (yeterli miktar belirtildiği varsayılarak 10 gram eklenmiştir)

//(31, 4, 1.250),  -- 5 su bardağı süt (≈ 1250 ml = 1.250 L)
//(31, 76, 0.200),   -- 1 su bardağı toz şeker (≈ 200 gram = 0.200 kg)
//(31, 78, 0.010),   -- 1 paket vanilya (≈ 10 gram = 0.010 kg)
//(31, 68, 0.020),   -- 1 adet yumurta sarısı (≈ 20 gram = 0.020 kg)
//(31, 84, 0.020),   -- 2 yemek kaşığı nişasta (≈ 20 gram = 0.020 kg)
//(31, 3, 0.020),   -- 2 yemek kaşığı un (≈ 20 gram = 0.020 kg)
//(31, 5, 0.180),   -- 1.5 çay bardağı krema (≈ 180 ml = 0.180 L)
//(31, 90, 0.200),   -- 1 paket bebe bisküvisi (≈ 200 gram = 0.200 kg)
//(31, 89, 0.200),   -- 15-20 adet çilek (≈ 200 gram = 0.200 kg)

//(32, 92, 0.500),  -- Hazır yufka (1 paket ≈ 500 gram = 0.500 kg)
//(32, 96, 0.250),  -- Böreklik lor peyniri (1 paket ≈ 250 gram = 0.250 kg)
//(32, 23, 0.050),  -- Maydanoz (yarım demet ≈ 50 gram = 0.050 kg)
//(32, 6, 0.250),  -- Kızartmak için sıvı yağ (1 su bardağı ≈ 250 ml = 0.250 L)

//(33, 56, 0.200),  -- 1 su bardağı kırmızı mercimek ≈ 200 gram = 0.200 kg
//(33, 58, 0.300),  -- 1.5 su bardağı ince köftelik bulgur ≈ 300 gram = 0.300 kg
//(33, 21, 0.150),  -- 1 baş kuru soğan ≈ 150 gram = 0.150 kg
//(33, 23, 0.050),  -- 1 demet maydanoz (≈ 50 gram = 0.050 kg)
//(33, 6, 0.075),  -- 5 yemek kaşığı sıvı yağ ≈ 75 ml = 0.075 L
//(33, 37, 0.050),  -- 1 demet taze soğan (≈ 50 gram = 0.050 kg)
//(33, 67, 0.050),  -- 2 yemek kaşığı salça (≈ 50 gram = 0.050 kg)
//(33, 1, 0.750),  -- 3 su bardağı su (≈ 750 ml = 0.750 L)
//(33, 8, 0.005),  -- Yeteri kadar tuz (≈ 5 gram = 0.005 kg)
//(33, 16, 0.002), -- Kimyon (yaklaşık 2 gram = 0.002 kg)
//(33, 9, 0.002), -- Pul biber (yaklaşık 2 gram = 0.002 kg)
//(33, 13, 0.002), -- Karabiber (yaklaşık 2 gram = 0.002 kg)

//(34, 24, 0.600),  -- 3 adet kabak ≈ 600 gram = 0.600 kg
//(34, 68, 0.100),  -- 2 adet yumurta ≈ 100 gram = 0.100 kg
//(34, 26, 0.150),  -- 1 adet havuç ≈ 150 gram = 0.150 kg
//(34, 3, 0.025),  -- 1 çay bardağı un (≈ 25 gram = 0.025 kg)
//(34, 37, 0.050),  -- 6 dal taze soğan (≈ 50 gram = 0.050 kg)
//(34, 19, 0.025),  -- 1/2 demet dereotu (≈ 25 gram = 0.025 kg)
//(34, 8, 0.005),  -- 1.5 çay kaşığı tuz (≈ 5 gram = 0.005 kg)
//(34, 13, 0.002),  -- 1 çay kaşığı karabiber (yaklaşık 2 gram = 0.002 kg)
//(34, 6, 0.025),  -- Kızartmak için 1/2 su bardağı sıvı yağ (≈ 125 ml = 0.125 L)

//(35, 92, 0.300),  -- 1 adet hazır yufka ≈ 300 gram = 0.300 kg
//(35, 30, 0.200),  -- 1 adet domates ≈ 100 gram = 0.100 kg
//(35, 31, 0.100),  -- 1 adet yeşil biber ≈ 50 gram = 0.050 kg
//(35, 41, 0.150),  -- 1 adet kırmızı kapya biber ≈ 75 gram = 0.075 kg
//(35, 94, 0.150),  -- 150 g rendelenmiş kaşar peyniri = 0.150 kg
//(35, 48, 0.150),  -- 150 g doğranmış pastırma = 0.150 kg
//(35, 6, 0.025),  -- Yaklaşık yarım çay bardağı sıvı yağ ≈ 25 ml = 0.025 L

//(36, 58, 0.200),  -- 1 büyük su bardağı ince bulgur ≈ 200 gram = 0.200 kg
//(36, 2, 0.125),  -- Yarım su sıcak su ≈ 125 ml = 0.125 L
//(36, 46, 0.075),  -- 3 yaprak marul ≈ 75 gram = 0.075 kg
//(36, 23, 0.050),  -- 1 demet maydanoz ≈ 50 gram = 0.050 kg
//(36, 37, 0.100),  -- 3 adet taze soğan ≈ 100 gram = 0.100 kg
//(36, 69, 0.030),  -- 1 yemek kaşığı zeytinyağı ≈ 15 ml = 0.015 L
//(36, 32, 0.050),  -- 1 küçük salatalık ≈ 50 gram = 0.050 kg
//(36, 40, 0.100),  -- 5 tane çeri domates ≈ 100 gram = 0.100 kg
//(36, 31, 0.050),  -- 1 tane orta boy sivri biber ≈ 50 gram = 0.050 kg
//--(36, 69, 0.015), -- Yarım çay bardağı zeytinyağı ≈ 15 ml = 0.015 L
//(36, 72, 0.015), -- 1 yemek kaşığı nar ekşisi ≈ 15 ml = 0.015 L
//(36, 13, 0.005), -- Karabiber ≈ 5 gram = 0.005 kg
//(36, 9, 0.005), -- Pul biber ≈ 5 gram = 0.005 kg
//(36, 16, 0.005), -- Kimyon ≈ 5 gram = 0.005 kg
//(36, 8, 0.005), -- Tuz ≈ 5 gram = 0.005 kg
//(36, 66, 0.015), -- 1 yemek kaşığı biber salçası ≈ 15 gram = 0.015 kg
//(36, 67, 0.010), -- 1 tatlı kaşığı domates salçası ≈ 10 gram = 0.010 kg
//(36, 28, 0.005), -- 1 diş sarımsak ≈ 5 gram = 0.005 kg
//(36, 21, 0.100),  -- 1 küçük soğan ≈ 100 gram = 0.100 kg

//(37, 21, 0.100),  -- 1 adet soğan ≈ 100 gram = 0.100 kg
//(37, 31, 0.050),   -- 1 adet yeşil biber ≈ 50 gram = 0.050 kg
//(37, 41, 0.050),   -- 1 adet kırmızı biber ≈ 50 gram = 0.050 kg
//(37, 30, 0.200),   -- 2 adet domates ≈ 200 gram = 0.200 kg
//(37, 28, 0.010),   -- 2 diş sarımsak ≈ 10 gram = 0.010 kg
//(37, 67, 0.015),   -- 1 yemek kaşığı dolusu salça ≈ 15 gram = 0.015 kg
//(37, 23, 0.005),   -- 1 tutam maydanoz ≈ 5 gram = 0.005 kg
//(37, 51, 0.500),   -- 500g kıyma = 0.500 kg
//(37, 10, 0.010),   -- 1’er tatlı kaşığı kırmızı toz biber ≈ 10 gram = 0.010 kg
//(37, 9, 0.010),  -- 1’er tatlı kaşığı pul biber ≈ 10 gram = 0.010 kg
//(37, 13, 0.005),  -- 1’er çay kaşığı karabiber ≈ 5 gram = 0.005 kg
//(37, 16, 0.005),  -- 1’er çay kaşığı kimyon ≈ 5 gram = 0.005 kg
//(37, 8, 0.010),  -- 1 tatlı kaşığı tuz ≈ 10 gram = 0.010 kg

//(38, 3, 0.750),  -- 5 su bardağı un ≈ 750 gram = 0.750 kg
//(38, 97, 0.025),   -- 1 paket instant maya ≈ 7 gram = 0.007 kg
//(38, 76, 0.015),   -- 1 yemek kaşığı toz şeker ≈ 15 gram = 0.015 kg
//(38, 8, 0.025),   -- Yarım yemek kaşığı tuz ≈ 5 gram = 0.005 kg
//(38, 69, 0.090),   -- 4 yemek kaşığı zeytinyağı ≈ 60 ml = 0.060 L
//(38, 2, 0.500),   -- 2 su bardağı ılık su ≈ 500 ml = 0.500 L
//(38, 30, 0.500),   -- 2 su bardağı domates sosu ≈ 500 ml = 0.500 L
//(38, 17, 0.005),   -- 1 çay kaşığı kuru fesleğen ≈ 5 gram = 0.005 kg
//(38, 15, 0.005),  -- 1 çay kaşığı kekik ≈ 5 gram = 0.005 kg

//(39, 25, 0.800),   -- 6 adet haşlanmış patates ≈ 800 gram = 0.800 kg
//(39, 37, 0.200),   -- 4 adet taze soğan ≈ 200 gram = 0.200 kg
//(39, 8, 0.005),   -- Tuz ≈ 5 gram = 0.005 kg
//(39, 13, 0.005),   -- Karabiber ≈ 5 gram = 0.005 kg
//(39, 94, 0.150),   -- Kaşar peyniri ≈ 150 gram = 0.150 kg
//(39, 3, 0.025),   -- Un (bulamak için) ≈ 25 gram = 0.025 kg
//(39, 68, 0.020),   -- Yumurta ≈ 20 gram = 0.020 kg
//(39, 91, 0.030),   -- Galeta unu ≈ 30 gram = 0.030 kg

//(40, 96, 0.150),   -- 5-6 yemek kaşığı lor peyniri ≈ 150 gram = 0.150 kg
//(40, 100, 0.020),   -- 2 yemek kaşığı dövülmüş ceviz içi ≈ 20 gram = 0.020 kg
//(40, 30, 0.030),   -- 6 adet kuru domates ≈ 30 gram = 0.030 kg
//(40, 69, 0.040),   -- 2-3 yemek kaşığı zeytinyağı ≈ 40 ml = 0.040 L
//(40, 18, 0.010),   -- 2 çay kaşığı çörekotu ≈ 10 gram = 0.010 kg
//(40, 23, 0.005),    -- 1 tutam maydanoz ≈ 5 gram = 0.005 kg
//(40, 19, 0.005),    -- 1 tutam dereotu ≈ 5 gram = 0.005 kg
//(40, 13, 0.005),    -- Karabiber ≈ 5 gram = 0.005 kg
//(40, 9, 0.005),    -- Pul biber ≈ 5 gram = 0.005 kg
//(40, 22, 0.005),   -- Nane ≈ 5 gram = 0.005 kg
//(40, 15, 0.005),   -- Kekik ≈ 5 gram = 0.005 kg

//(41, 30, 0.300),  -- 2-3 tane domates ≈ 300 gram = 0.300 kg
//(41, 21, 0.100),  -- 1 tane kuru soğan ≈ 100 gram = 0.100 kg
//(41, 45, 0.020),  -- Taze fesleğen (isteğe bağlı) ≈ 20 gram = 0.020 kg
//(41, 24, 0.200),  -- İstenirse kızarmış kabak ≈ 200 gram = 0.200 kg
//(41, 44, 0.200),  -- İstenirse kızarmış patlıcan ≈ 200 gram = 0.200 kg
//(41, 95, 0.200),  -- Mozzarella peyniri ≈ 200 gram = 0.200 kg
//(41, 28, 0.005),  -- 1 diş sarımsak ≈ 5 gram = 0.005 kg
//(41, 6, 0.080),  -- 5-6 yemek kaşığı sıvı yağ ≈ 80 gram = 0.080 kg
//(41, 8, 0.005),  -- Tuz (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(41, 54, 0.100), -- İstenirse füme somon ≈ 100 gram = 0.100 kg
//(41, 99, 0.400), -- 1 ekmek ≈ 400 gram = 0.400 kg

//(42, 54, 0.500),  -- Yarım kg tavuk göğsü = 0.500 kg
//(42, 6, 0.030),  -- 2 yemek kaşığı sıvı yağ ≈ 30 gram = 0.030 kg
//(42, 67, 0.020),  -- 1 tatlı kaşığı domates salçası ≈ 20 gram = 0.020 kg
//(42, 31, 0.200),  -- 2 adet yeşil biber ≈ 100 gram = 0.100 kg
//(42, 41, 0.200),  -- 1 adet kırmızı biber ≈ 100 gram = 0.100 kg
//(42, 21, 0.100),  -- 1 adet soğan ≈ 100 gram = 0.100 kg
//(42, 28, 0.010),  -- 2 diş sarımsak ≈ 10 gram = 0.010 kg
//(42, 30, 0.400),  -- 2 adet domates ≈ 200 gram = 0.200 kg
//(42, 13, 0.005),  -- Karabiber (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(42, 9, 0.005), -- Pul biber (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(42, 8, 0.005), -- Tuz (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(42, 1, 0.250), -- 1 su bardağı su ≈ 250 ml = 0.250 L

//(43, 44, 0.600),  -- 6 adet küçük boy patlıcan ≈ 600 gram = 0.600 kg
//(43, 31, 0.500),  -- 5 adet sivri biber 
//(43, 21, 0.200),  -- 2 adet orta boy soğan ≈ 200 gram = 0.200 kg
//(43, 30, 0.400),  -- 2 adet domates ≈ 200 gram = 0.200 kg
//(43, 28, 0.010),  -- 2 diş sarımsak ≈ 10 gram = 0.010 kg
//(43, 8, 0.005),  -- Tuz (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(43, 13, 0.005),  -- Karabiber (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(43, 41, 0.005),  -- Kırmızı biber (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(43, 51, 0.200), -- 200 gram kıyma = 0.200 kg
//(43, 67, 0.015), -- 1 yemek kaşığı salça ≈ 15 gram = 0.015 kg
//(43, 2, 0.270), -- 1 su bardağı sıcak su ≈ 250 ml = 0.250 L+1 çay bardağı sıcak su ≈ 20 ml = 0.020 L

//(44, 59, 0.400),  -- 2 su bardağı kuru fasulye ≈ 400 gram = 0.400 kg
//(44, 21, 0.100),  -- 1 adet kuru soğan ≈ 100 gram = 0.100 kg
//(44, 30, 0.400),  -- 2 adet domates ≈ 200 gram = 0.200 kg
//(44, 31, 0.200),  -- 2 adet sivri biber ≈ 100 gram = 0.100 kg
//(44, 51, 0.100),  -- 100 gram kıyma = 0.100 kg
//(44, 67, 0.008),  -- Yarım yemek kaşığı salça ≈ 8 gram = 0.008 kg
//(44, 8, 0.01),  -- Tuz (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(44, 13, 0.005),  -- Karabiber (isteğe bağlı) ≈ 5 gram = 0.005 kg
//(44, 57, 0.400), -- 2 su bardağı pirinç ≈ 400 gram = 0.400 kg
//(44, 60, 0.025), -- Yarım çay bardağı arpa şehriye ≈ 25 gram = 0.025 kg
//(44, 7, 0.015), -- 1 yemek kaşığı tereyağı ≈ 15 gram = 0.015 kg
//(44, 2, 0.500), -- 3,5 su bardağı sıcak su ≈ 700 ml = 0.700 L

//(45, 25, 0.300),   -- 2-3 adet patates ≈ 300 gram = 0.300 kg (ortalama)
//(45, 31, 0.200),   -- 2-3 adet yeşil biber ≈ 200 gram = 0.200 kg (ortalama)
//(45, 30, 0.400),   -- 2 adet domates ≈ 400 gram = 0.400 kg
//(45, 6, 0.045),   -- Sıvı yağ (3 yemek kaşığı ≈ 45 ml = 0.045 L)
//(45, 67, 0.022),   -- 1.5 yemek kaşığı domates salçası ≈ 22 gram = 0.022 kg
//(45, 51, 0.500),   -- Yarım kg kıyma = 0.500 kg
//(45, 21, 0.100),   -- 1 adet kuru soğan ≈ 100 gram = 0.100 kg
//(45, 28, 0.015),   -- 2-3 diş sarımsak (ortalama 15 gram) = 0.015 kg
//(45, 68, 0.050),   -- 1 adet yumurta ≈ 50 gram = 0.050 kg
//(45, 99, 0.050),  -- Yarım su bardağı kadar ufalanmış bayat ekmek içi ≈ 50 gram = 0.050 kg
//(45, 8, 0.005),  -- Tuz (1 çay kaşığı ≈ 5 gram) = 0.005 kg
//(45, 13, 0.005),  -- Karabiber (1 çay kaşığı ≈ 5 gram) = 0.005 kg
//(45, 9, 0.005),  -- Pul biber (1 çay kaşığı ≈ 5 gram) = 0.005 kg

//(46, 7, 0.050),   -- 1 yemek kaşığı tereyağı ≈ 15 gram = 0.015 kg (3 yemek kaşığı için 0.050 kg)
//(46, 10, 0.005),   -- 1 tatlı kaşığı kırmızı toz biber ≈ 5 gram = 0.005 kg
//(46, 29, 0.005),   -- 1 tatlı kaşığı limon suyu ≈ 5 gram = 0.005 kg
//(46, 8, 0.005),   -- 1 çay kaşığı tuz ≈ 5 gram = 0.005 kg
//(46, 13, 0.005),   -- 1 çay kaşığı karabiber ≈ 5 gram = 0.005 kg
//(46, 52, 1.500),   -- 1 adet orta boy bütün tavuk ≈ 1.500 kg
//(46, 21, 0.300),   -- 3 adet soğan ≈ 100 gram = 0.100 kg
//(46, 27, 0.005),   -- 1 adet defne yaprağı ≈ 5 gram = 0.005 kg
//(46, 42, 0.020),   -- 1 dal biberiye ≈ 2 gram = 0.002 kg
//(46, 25, 0.300),  -- 1 adet büyük boy patates ≈ 300 gram = 0.300 kg
//(46, 69, 0.045),  -- 3 yemek kaşığı zeytinyağı ≈ 45 ml = 0.045 L

//(47, 43, 0.500),   -- Yarım kg dolmalık biber = 0.500 kg
//(47, 57, 0.050),   -- Her biber için 1 yemek kaşığı pirinç = yaklaşık 10 gram = 0.010 kg
//(47, 21, 0.100),   -- 1 adet soğan ≈ 100 gram = 0.100 kg
//(47, 67, 0.020),   -- 1 yemek kaşığı salça = yaklaşık 20 gram = 0.020 kg
//(47, 23, 0.010),   -- Maydanoz ≈ 10 gram = 0.010 kg
//(47, 30, 0.500),   -- 2-3 adet domates ≈ 500 gram = 0.500 kg
//(47, 13, 0.005),   -- Karabiber ≈ 5 gram = 0.005 kg
//(47, 8, 0.020),   -- Tuz ≈ 20 gram = 0.020 kg
//(47, 12, 0.010),   -- Nane ≈ 10 gram = 0.010 kg
//(47, 69, 0.050),  -- Sıvı yağ/Zeytinyağı ≈ 50 ml = 0.050 L

//(48, 3, 0.500),   -- 4 su bardağı un = yaklaşık 500 gram = 0.500 kg
//(48, 76, 0.015),   -- 1.5 çay kaşığı toz şeker = yaklaşık 5 gram = 0.005 kg
//(48, 8, 0.025),   -- 2 çay kaşığı tuz = yaklaşık 10 gram = 0.010 kg
//(48, 97, 0.010),   -- 1 yemek kaşığı instant maya = yaklaşık 10 gram = 0.010 kg
//(48, 2, 0.375),   -- 1.5 su bardağı ılık su = yaklaşık 375 ml = 0.375 L
//(48, 7, 0.060),   -- 4 yemek kaşığı tereyağı = yaklaşık 60 gram = 0.060 kg
//(48, 6, 0.025),   -- 0.5 çay bardağı sıvı yağ = yaklaşık 25 ml = 0.025 L
//(48, 21, 0.100),   -- 1 adet orta boy soğan = yaklaşık 100 gram = 0.100 kg
//(48, 51, 0.500),   -- 500 gram orta yağlı dana kıyma = 0.500 kg
//(48, 67, 0.020),  -- 1 yemek kaşığı (tepeleme) domates salçası = yaklaşık 20 gram = 0.020 kg
//(48, 30, 0.625),  -- 2.5 su bardağı domates püresi = yaklaşık 625 ml = 0.625 L
//--(48, 8, 0.015),  -- 1.5 çay kaşığı tuz = yaklaşık 5 gram = 0.005 kg
//(48, 13, 0.005),  -- 1 çay kaşığı karabiber = yaklaşık 5 gram = 0.005 kg
//(48, 1, 0.375),  -- 1.5 su bardağı su = yaklaşık 375 ml = 0.375 L
//(48, 65, 0.250),  -- 1 su bardağı yoğurt = yaklaşık 250 gram = 0.250 kg
//(48, 23, 0.010),  -- 1 avuç maydanoz = yaklaşık 10 gram = 0.010 kg

//(49, 24, 0.400),  -- 2 orta boy kabak = yaklaşık 400 gram = 0.400 kg
//(49, 44, 0.800),  -- 2 büyük patlıcan = yaklaşık 800 gram = 0.800 kg
//(49, 25, 0.600),  -- 3 patates = yaklaşık 600 gram = 0.600 kg
//(49, 31, 0.200),  -- 4 yeşil biber = yaklaşık 200 gram = 0.200 kg
//(49, 53, 0.300),  -- 300 gram kuşbaşı et = 0.300 kg
//(49, 67, 0.025),  -- Salça: yaklaşık 25 gram = 0.025 kg

//(50, 53, 1),      -- 1 kg kuşbaşı dana eti
//(50, 1, 0.400),      -- 2 bardak su (1 bardak = 0.25 litre, toplam 0.5 litre = 2 bardak)
//(50, 15, 0.005),  -- Kekik (0.5 tatlı kaşığı = yaklaşık 2.5 gram)
//(50, 16, 0.005),  -- Kimyon (0.5 tatlı kaşığı = yaklaşık 2.5 gram)
//(50, 13, 0.005),  -- Karabiber (0.5 tatlı kaşığı = yaklaşık 2.5 gram)
//(50, 8, 0.005),  -- Tuz (0.5 tatlı kaşığı = yaklaşık 2.5 gram)
//(50, 6, 0.090),  -- 2 yemek kaşığı sıvı yağ = 30 ml = 0.030 litre
//(50, 7, 0.045),  -- 1 yemek kaşığı tereyağı = yaklaşık 15 gram = 0.015 kg
//(50, 57, 0.400),  -- 2 su bardağı pirinç = yaklaşık 400 gram = 0.400 kg
//(50, 60, 0.040),  -- 3 yemek kaşığı şehriye = yaklaşık 40 gram = 0.040 kg
//(50, 2, 0.875),  -- 3.5-4 su bardağı sıcak su = yaklaşık 875 ml = 0.875 litre
//--
//(51,51, 1),           -- 1 kilogram kıyma (arzuya göre dana/kuzu karışık)
//(51, 21, 0.1),          -- 1 adet soğan (ortalama 100 gram)
//(51, 23, 0.1),         -- 1 demet maydanoz (ortalama 100 gram)
//(51, 31, 0.3),         -- 3 adet sivri biber (ortalama 300 gram)
//(51, 28, 0.015),       -- 3 diş sarımsak (ortalama 15 gram)
//(51, 16, 0.005),       -- 1/2 tatlı kaşığı kimyon (~0.5 gram)
//(51, 8, 0.005),        -- 1/2 tatlı kaşığı tuz (~0.5 gram)
//(51, 13, 0.005),       -- 1/2 tatlı kaşığı karabiber (~0.5 gram)
//(51, 9, 0.005),       -- 1/2 tatlı kaşığı pul biber (~0.5 gram)
//(51, 7, 0.06),         -- 4 yemek kaşığı tereyağı (~60 gram)
//(51, 66, 0.045),       -- 1.5 yemek kaşığı biber salçası (~45 gram)
//(51, 1, 0.25),         -- 1 su bardağı su (~250 ml)
//(51, 30, 0.1),         -- 1 adet domates (ortalama 100 gram)
//(51, 41, 0.1),         -- 1 adet kırmızı biber (ortalama 100 gram)

//(52, 51, 0.2),     -- 200 g kıyma
//(52, 25, 0.6),      -- 3 adet orta boy patates (ortalama 600 gram)
//(52, 21, 0.1),       -- 1 adet soğan (ortalama 100 gram)
//(52, 58, 0.02),     -- 2 yemek kaşığı kısırlık bulgur (~20 gram)
//(52, 27, 0.04),     -- 2 yemek kaşığı domates salçası (~40 gram)
//(52, 6, 0.03),      -- 2 yemek kaşığı sıvı yağ (~30 ml)
//(52, 3, 0.02),     -- 2 yemek kaşığı kadar un (~20 gram)
//(52, 28, 0.005),    -- 2-3 diş ezilmiş sarımsak (~5 gram)
//(52, 8, 0.005),         -- Tuz (~5 gram, isteğe bağlı)
//(52, 13, 0.005),      -- Karabiber (~0.5 gram, isteğe bağlı)
//(52, 9, 0.005),      -- Pul biber (~0.5 gram, isteğe bağlı)
//(52, 41, 0.005);      -- Kırmızı biber (~0.5 gram, isteğe bağlı)

