## 🏓 Masa Tenisi Turnuvası (Table Tennis Tournament) - Çözüm Yaklaşımları

Bu projede, masa tenisi turnuvası problemini çözmek için iki farklı algoritma yaklaşımı geliştirilmiştir. Aşağıda her iki yöntemin çalışma mantığı ve karmaşıklık (Complexity) analizleri detaylandırılmıştır.

### 1. Kaba Kuvvet (Brute Force) Çözüm
**Mantığı:**
Brute force yaklaşımında, turnuvadaki her bir eşleşme ve tur manuel olarak simüle edilir. Algoritma, eşleşebilecek tüm oyuncu kombinasyonlarını iç içe döngüler kullanarak tarar ve her turda kazananları yeni bir listeye ekleyerek süreci bir sonraki tur için baştan başlatır. 

**Dezavantajı:**
Gereksiz bellek tahsisatları ve iç içe döngüler nedeniyle oyuncu sayısı ($N$) büyüdükçe performans logaritmik olarak değil, üstel olarak düşmeye başlar.

* **Zaman Karmaşıklığı (Time Complexity):** O(N^2) - Oyuncuların ve turların iç içe döngülerle tamamen taranması.
* **Alan Karmaşıklığı (Space Complexity):** O(N) - Her tur için kazananların tutulduğu geçici yeni diziler/listeler oluşturulması.

---

### 2. Optimize Edilmiş (Ortalama/Optimal) Çözüm
**Mantığı:**
Bu yaklaşımda problem, ardışık ve ağır simülasyonlar yerine **[Böl ve Fethet (Divide & Conquer) / Queue (Kuyruk) Veri Yapısı / İki İşaretçi (Two Pointers) - projene uygun olanı bırak]** mantığı kullanılarak çözülmüştür. Oyuncular uygun bir veri yapısına alınarak, gereksiz döngülerden kaçınılır ve sadece gerçekleşmesi gereken maçlar $O(1)$ işlem maliyetiyle yönetilir.

**Avantajı:**
Döngü sayısı minimuma indirildiği için işlemci (CPU) yükü azalır. Geçici listeler kopyalamak yerine mevcut veri yapısı üzerinden ilerlendiği veya veri yapısı dinamik olarak küçültüldüğü için bellek dostudur.

* **Zaman Karmaşıklığı (Time Complexity):** $O(N)$ veya $O(\log N)$ - İterasyon sayısının sadece ağaç derinliğine (tur sayısına) veya toplam maç sayısına eşit olması.
* **Alan Karmaşıklığı (Space Complexity):** $O(1)$ veya $O(N)$ - İşlemlerin minimum ekstra bellekle tamamlanması.

---

### 📊 Karşılaştırma Tablosu

| Yaklaşım | Zaman Karmaşıklığı | Alan Karmaşıklığı | Ölçeklenebilirlik (Büyük Veri Setleri) |
| :--- | :--- | :--- | :--- |
| **Brute Force** | O(N^2) | $O(N)$ | Düşük (Yavaş çalışır) |
| **Optimize Çözüm** | O(N \log N) veya O(N) | $O(1)$ veya O(N) | Yüksek (Performanslı çalışır) |
