### 💌 **Authentication System in ASP.NET Core MVC**

**AuthenticationSystemMVC-ASPnet-Core** is a project demonstrating how to integrate **ASP.NET Core Identity** and external authentication providers (**Google, Facebook, and Microsoft**) using **OAuth 2.0**.

🔹 **Tech Stack:**

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Identity Framework**
- **OAuth 2.0 Authentication**
- **Google, Facebook, and Microsoft Authentication**

---

## 🚀 **Features**

✔ Implement **ASP.NET Core Identity** for authentication & user management.\
✔ Authenticate users using **Google, Facebook, and Microsoft accounts**.\
✔ Secure login using **OAuth 2.0** authentication flow.\
✔ Store user data securely using **Entity Framework Core**.\
✔ Fully configurable via **appsettings.json**.

---

## ⚙️ **Installation & Setup**

### **1️⃣ Clone the repository**

```bash
git clone https://github.com/Omar-Khc/AuthenticationSystemMVC-ASPnet-Core.git
cd AuthenticationSystemMVC-ASPnet-Core
```

### **2️⃣ Install dependencies**

Ensure you have the required dependencies installed via NuGet:

```bash
dotnet restore
```

### **3️⃣ Configure Authentication Providers**

To enable external login providers (**Google, Facebook, Microsoft**), configure your **appsettings.json** file with your **Client ID** and **Client Secret** from OAuth providers.

🔹 Example **appsettings.json**:

```json
"Authentication": {
  "Google": {
    "ClientId": "your-google-client-id",
    "ClientSecret": "your-google-client-secret"
  },
  "Facebook": {
    "ClientId": "your-facebook-client-id",
    "ClientSecret": "your-facebook-client-secret"
  },
  "Microsoft": {
    "ClientId": "your-microsoft-client-id",
    "ClientSecret": "your-microsoft-client-secret"
  }
}
```

---

## 🔑 **Authentication Setup**

To integrate **OAuth 2.0** authentication providers, follow these official ASP.NET Core guides:

### **1️⃣ Google Authentication**

🔗 [**Microsoft Docs: Google OAuth Setup**](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/google-logins)

```csharp
services.AddAuthentication()
    .AddGoogle(googleOptions =>
    {
        googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
        googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
    });
```

---

### **2️⃣ Facebook Authentication**

🔗 [**Microsoft Docs: Facebook OAuth Setup**](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/facebook-logins)

```csharp
services.AddAuthentication()
    .AddFacebook(facebookOptions =>
    {
        facebookOptions.ClientId = Configuration["Authentication:Facebook:ClientId"];
        facebookOptions.ClientSecret = Configuration["Authentication:Facebook:ClientSecret"];
    });
```

---

### **3️⃣ Microsoft (Hotmail) Authentication**

🔗 [**Microsoft Docs: Microsoft OAuth Setup**](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/microsoft-logins)

```csharp
services.AddAuthentication()
    .AddMicrosoftAccount(microsoftOptions =>
    {
        microsoftOptions.ClientId = Configuration["Authentication:Microsoft:ClientId"];
        microsoftOptions.ClientSecret = Configuration["Authentication:Microsoft:ClientSecret"];
    });
```

---

## 🛠 **How to Run the Project**

1. Ensure you have **.NET SDK** installed.
2. Update **OAuth credentials** in `appsettings.json`.
3. Run the migration to update the database:
   ```bash
   dotnet ef database update
   ```
4. Start the application:
   ```bash
   dotnet run
   ```
5. Open a browser and navigate to:
   ```
   https://localhost:5001
   ```

---

## 📚 **Resources**

- **ASP.NET Core Authentication Overview**: [🔗 Link](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/)
- **OAuth 2.0 and OpenID Connect**: [🔗 Link](https://auth0.com/docs/protocols/oauth2)
- **Identity Framework in ASP.NET Core**: [🔗 Link](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity)

---

## 🤝 **Contributing**

Feel free to submit **Pull Requests** or open an **Issue** if you find any bugs or improvements.

---

## 📩 **Contact**

For questions or suggestions, feel free to reach out via: 
📞 **Email:** `omarabubrayo6@gmail.com`\
🌐 **GitHub:** [Omar-Khc](https://github.com/Omar-Khc)

---

🔹 **Enjoy building secure authentication with ASP.NET Core! 🚀🔥**

