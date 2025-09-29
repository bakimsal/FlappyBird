# Flappy Bird (Windows Forms, C#)

Basit bir **Flappy Bird klonu**.  
Windows Forms ve C# ile geliştirilmiştir.  

**Space** ile zıpla, borulardan geçerek skor topla. 🎮

---

## Özellikler
- 🐦 Kuş yerçekimi ve zıplama mekaniği  
- 🟩 Rastgele aralıklı çift borular  
- 🏆 Skor takibi ve artan zorluk (boru hızı artar)  
- 🔄 Oyun bittiğinde **R** ile yeniden başlatma  
- ⚡ 50 FPS civarı akıcı **Timer** tabanlı döngü  

---

## Ekran Görüntüsü
Eğer eklemek isterseniz:  

Markdown içinde gösterimi:  

![Flappy Bird](docs/screenshot.png)

---

## Gerekli Yazılımlar
- Visual Studio 2022 veya üstü  
- .NET 6/7/8 (projede seçili hedef sürüme göre)  
- Windows  

---

## Kurulum
1. Depoyu klonla:  
   ```bash
   git clone https://github.com/kullanici/flappybird.git
Çalıştırma

*Visual Studio’dan: F5

*Ya da derlemeden sonra:

*Debug: FlappyBird\bin\Debug\netX-windows\FlappyBird.exe

*Release: FlappyBird\bin\Release\netX-windows\FlappyBird.exe

*Not: netX-windows hedef çerçeveye göre değişir (ör. net8.0-windows).

Kontroller

*Space → Zıpla

*R → Oyun bittiyse yeniden başlat

*ESC → Uygulamadan çıkış (eklerseniz)

Proje Yapısı

*Form1.cs → Oyun mantığı (zıplama, hareket, çarpışma, skor)

*Form1.Designer.cs → Form ve kontrollerin otomatik oluşturulan tanımları

*Properties/Resources.resx → İsteğe bağlı görseller

*docs/ → Ekran görüntüleri vb. (isteğe bağlı)

Teknik Notlar

*Oyun döngüsü Timer ile (Interval = 20 ms) çalışır.

*Kuş, gravity ile aşağı çekilir; Space ile geçici olarak negatif gravity uygulanır.

*Borular Tag değeri ile seçilir ve ekrandan çıkınca sağa taşınır.

*Skor sadece alt boru yeniden konumlandığında artırılır.

Derleme / Publish

*Build → Build Solution (Ctrl+Shift+B)

*Release almak için: Visual Studio’da Configuration → Release

*Tek klasöre yayınlamak:

*Build → Publish → Folder → Publish

*Çıktı: FlappyBird\bin\Release\netX-windows\publish\

Katkıda Bulunma

*Issue açın veya PR gönderin.

*Kod stili: Varsayılan .NET stil kuralları.

*Anlamlı commit mesajları tercih edilir.
