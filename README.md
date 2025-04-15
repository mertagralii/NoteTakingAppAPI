## 📝 NoteTakingAppAPI

Bu proje, basit bir not alma uygulamasının backend API'sini sunar. Kullanıcılar not oluşturabilir, görüntüleyebilir, güncelleyebilir ve silebilir. Proje ASP.NET Core Web API kullanılarak geliştirilmiştir ve Entity Framework Core ile veri erişimi sağlanmaktadır.

---

### 🚀 Kullanılan Teknolojiler

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- AutoMapper
- FluentValidation
- Swagger (API dokümantasyonu için)

---

### 📂 Katmanlar

- **NoteTakingAppAPI:** API uç noktalarını barındırır.
- **NoteTakingApp.Application:** İş mantığı, servisler ve DTO'lar.
- **NoteTakingApp.Domain:** Varlıklar (Entities) ve arayüzler (Interfaces).
- **NoteTakingApp.Persistence:** Entity Framework üzerinden veri erişim işlemleri.

---

### 🧱 Özellikler

- Not ekleme 🆕
- Notları listeleme 📃
- Not güncelleme ✏️
- Not silme 🗑️
- Model doğrulama (FluentValidation ile)
- Swagger UI ile test edilebilir API 👨‍💻

---

### 🔧 Kurulum

1. Projeyi klonlayın:

```bash
git clone https://github.com/mertagralii/NoteTakingAppAPI.git
```

2. Proje dizinine gidin ve gerekli NuGet paketlerini yükleyin:

```bash
dotnet restore
```

3. Veritabanını oluşturmak için migration ve update komutlarını çalıştırın:

```bash
cd NoteTakingAppAPI.Persistence
dotnet ef database update
```

4. API projesini başlatın:

```bash
cd ../NoteTakingAppAPI
dotnet run
```

---

### 🔍 Örnek API Kullanımı

#### ✅ Not Ekleme
```http
POST /api/notes
Content-Type: application/json

{
  "title": "Yapılacaklar",
  "content": "1. Spor
2. Ders çalış"
}
```

#### 📃 Tüm Notları Listeleme
```http
GET /api/notes
```

#### ✏️ Not Güncelleme
```http
PUT /api/notes/{id}
Content-Type: application/json

{
  "title": "Yeni Başlık",
  "content": "Güncellenmiş içerik"
}
```

#### 🗑️ Not Silme
```http
DELETE /api/notes/{id}
```

---

### 📌 Notlar

- Swagger UI üzerinden kolayca test edebilirsiniz: `https://localhost:{port}/swagger`
- FluentValidation ile gönderilen veriler kontrol edilir. Eksik veya hatalı alanlarda açıklayıcı hata mesajları döner.

---

### 📫 İletişim
Herhangi bir öneri ya da geri bildirimin varsa bana GitHub üzerinden ulaşabilirsin! 😊

---

Proje sahibi: [Mert AĞRALİ](https://github.com/mertagralii)
