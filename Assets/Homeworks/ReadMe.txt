28.04.2026

Şu anda sadece Brown_bear_prefab aktif.

Oyuncuyla bu hayvanın yanına yaklaşıp ekrandaki talimatları uygularsanız, hayvanın animasyonlarını test edebilirsiniz.

Ne yapılacak?

Ben şu animasyonları ekledim:
Run, Attack, Die

Bunların sesleri ve animation event kurguları hiç yok. Bunlar için Animation Event'leri siz oluşturacaksınız. BAPAnimalSoundPlayer scriptindeki fonksiyonlara bakabilirsiniz.

Derste Eat animasyonu için bir ses kullanmıştık ama bu uyduruk bir sesti. Bir yeme sesi tasarlayıp bunu sistemde kullanacaksınız.

Hatırlarsanız, dosya isimlendirmesini [Hayvan]_[Sesin Fonksiyonu] şeklinde yapıyorduk. Ve bu sesleri Audio/Resources içine atıyorduk.

Ve yine hatırlarsanız, animasyonlara Animation Event'leri koymak için "read-only" olan animasyonları kopyalayıp yeni animasyon yapıyorduk. Ben bu işlemi sizin için yaptım. Sizin tek yapmanız gereken "read-only" olmayan versiyonlarını açıp Animation Event'leri eklemek.

Ve yine hatırlarsınız ki, animasyonları edit etmek için önce hiyerarşide hayvanı seçmek lazım. Hayvan seçini olmazsa başka bir objenin animasyonlarını editliyor olabilirsiniz. Tüm zamanlarda hayvanın hiyerarşide seçili olduğuna dikkat edin.

İyi eğlenceler.