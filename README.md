# Marquitos Primer Blazor Components
[![NuGet Version](https://img.shields.io/nuget/v/Marquitos.Primer.Blazor.svg?style=flat-square)](https://www.nuget.org/packages/Marquitos.Primer.Blazor/)
[![Build Status](https://img.shields.io/github/actions/workflow/status/marquitospt/Marquitos.Primer.Blazor/dotnet.yml?branch=main&style=flat-square)]()
[![License](https://img.shields.io/github/license/marquitospt/Marquitos.Primer.Blazor.svg?style=flat-square)](LICENSE)  

Componentes Blazor inspirados no **Primer Brand UI** do GitHub — o design system usado em GitHub.com/marketing.

**Objetivo:** trazer para Blazor os mesmos componentes de marketing usados pelo GitHub: Hero, CTA, Section Intro, Bento, River, LogoGrid, Testimonial, Timeline, Feature Comparison e muito mais.

## 📦 Instalação

```bash

dotnet add package Marquitos.Primer.Blazor

```

Ou adiciona ao `.csproj`:


```xml

<PackageReference Include="Marquitos.Primer.Blazor" Version="1.0.0" />

```

## Registar a biblioteca Marquitos Primer Components na coleção de serviços

No `Program.cs` adiciona a seguinte linha:

```csharp

builder.Services.AddMarquitosPrimerComponents();

```

## 🎨 Importar o CSS global da biblioteca Marquitos Primer Components

No `index.html` (WASM) ou `_Layout.cshtml` ou `App.razor` (Server):

```html

<link rel="stylesheet" href="\_content/Marquitos.Primer.Blazor/style.css">

```


## 🚀 Uso básico

### Hero

```razor

<Hero Alignment="start">

   <HeroLabel>New</HeroLabel>

   <HeroHeading>Build like GitHub</HeroHeading>

   <HeroDescription>

       Components inspirados no Primer Brand UI, agora em Blazor.

   </HeroDescription>

   <HeroPrimaryAction Href="#get-started">Get started</HeroPrimaryAction>

   <HeroSecondaryAction Href="#components">View components</HeroSecondaryAction>

</Hero>

```


## 📚 Componentes incluídos

### 🟦 Marketing Components

- Hero

### 🟩 UI Components

- Box  


## 🛠️ Roadmap

### **v1.0.0**

✔️ Hero  

✔️ CTA Banner  

✔️ Section Intro  

✔️ LogoGrid  

✔️ Testimonial  

✔️ Timeline  

✔️ Feature Comparison  

✔️ River  

✔️ Bento  

✔️ Card  

✔️ Box  

✔️ Buttons  

✔️ Typography  

✔️ Stack / Grid  

✔️ Demo App  


### **v1.1.0**

⬜ Tokens de design  

⬜ Dark mode  

⬜ Animações  

⬜ Nav / Footer  


### **v2.0.0**

⬜ Gerador de landing pages  

⬜ CLI  

⬜ Editor visual  


## 🤝 Contribuir

1. Faz fork do repositório  

2. Cria uma branch de feature  

3. Commit com mensagens claras  

4. Abre um Pull Request  


## 📄 Licença

MIT — livre para uso comercial e open-source.



