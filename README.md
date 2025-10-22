# nArchitecture

**nArchitecture**, .NET platformu üzerinde **Clean Architecture** prensiplerini, yeniden kullanılabilir ve modüler bir **Persistence (Veri Erişim)** katmanıyla birleştiren gelişmiş bir çözüm şablonudur.

Bu proje, N-Katmanlı mimarilerin esnekliğini Temiz Mimarinin (Clean Architecture) katı bağımlılık kuralları ve test edilebilirliği ile bir araya getirmeyi amaçlar.

## 🚀 Temel Felsefe

Projenin temel felsefesi, standart Clean Architecture katmanlarını korurken, veri erişimi gibi altyapı (infrastructure) endişelerini projeye özel implementasyonlardan soyutlayan, *yeniden kullanılabilir bir çekirdek (core) framework* sağlamaktır.

## 📂 Proje Yapısı

Çözüm, ana Clean Architecture katmanlarının yanı sıra paylaşılan bir çekirdek kütüphane içerir:

* **Domain (Alan Adı):**
    * Projenin kalbidir. Varlıkları (Entities), ortak sınıfları (Aggregates) ve iş kurallarını içerir.
    * Diğer hiçbir katmana bağımlılığı yoktur.
* **Application (Uygulama):**
    * Uygulamanın iş mantığını (use case'ler) yönetir.
    * CQRS (Commands & Queries), MediatR, DTO'lar ve FluentValidation gibi araçları barındırır.
    * Gerekli altyapı servisleri için `Interface`'ler (Arayüzler) tanımlar.
* **Infrastructure (Altyapı):**
    * Veritabanı dışındaki dış servislerin (E-posta, Ödeme Sistemleri, Dosya Depolama vb.) somut implementasyonlarını içerir.
* **Persistence (Veri Erişimi):**
    * Bu projeye *özel* veri erişim katmanıdır.
    * `Application` katmanındaki Repository arayüzlerini ve `nArchitecture.Persistence` kütüphanesini kullanarak Entity Framework Core implementasyonlarını (DbContext, Repository'ler) içerir.
* **WebApi (Sunum Katmanı):**
    * Dış dünyaya açılan RESTful API uç noktalarını barındırır.
    * `Application` katmanıyla MediatR komutları/sorguları üzerinden iletişim kurar.

### ✨ Çekirdek Kütüphane

* **nArchitecture.Persistence:**
    * Bu, projenin en önemli parçalarından biridir.
    * Genel (Generic) Repository deseni, temel varlık (Base Entity) sınıfları ve farklı projelerde *yeniden kullanılabilen* temel veritabanı mantığını içeren paylaşılan bir kütüphanedir.
    * Amacı, yeni projelerde veri erişim katmanını sıfırdan yazmak yerine standartlaştırılmış bir temel sağlamaktır.
