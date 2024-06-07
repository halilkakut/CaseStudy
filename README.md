-- Kod Üretme
-- NEWID(): Bu işlev, benzersiz bir GUID (Globally Unique Identifier) üretir. Her çağrıldığında farklı bir değer döner.

CHECKSUM(NEWID()): Bu işlev, verilen değer için bir CHECKSUM hesaplar. CHECKSUM, verilen girdiyi sayısal bir değere dönüştürür. GUID kullanarak bir sayısal değere dönüştürür.

ABS(CHECKSUM(NEWID())): CHECKSUM tarafından döndürülen değerin mutlak değeri (pozitif) alınır. Bu, negatif sayıları pozitif hale getirir.

% 22: MOD operatörü (%), ABS(CHECKSUM(NEWID())) değerini 22'ye böler ve kalanını döndürür. Bu, 0 ile 21 arasında bir sayı üretir.

+ 1: Bu işlemi yaparak 0-21 aralığındaki sayıyı 1-22 aralığına taşır. Böylece @charIndex değişkeni 1 ile 22 arasında bir değer alır.

İkinci Satır: SET @code = @code + SUBSTRING(@charset, @charIndex, 1);
SUBSTRING(@charset, @charIndex, 1): @charset dizisinden, @charIndex konumundan başlayarak 1 karakter çıkarır. @charset değişkeni, önceden belirlenmiş karakter kümesini içerir (örneğin, 'ACDEFGHKLMNPRTXYZ234579').

@code = @code + ...: Elde edilen karakter, @code değişkenine eklenir. Bu işlem, @code değişkeninin mevcut içeriğine yeni bir karakter ekler. Döngü her çalıştığında, @code değişkeni daha uzun bir hale gelir.

Bu iki satır, döngü içinde tekrarlandığında, @code değişkeninde benzersiz bir kod oluşturulur. Kod her çalıştığında, karakter kümesinden rastgele bir karakter seçilir ve bu karakter @code değişkenine eklenir. Bu süreç, istenen uzunlukta bir kod elde edilene kadar devam eder.

-----------------------------------------------------------------------------------------------------------------------

-- Json dosyası parse etme
-- program.cs de belirli bir json dosyası .net 6.0 da C# ile parse edilmiştir.
