# 🍽️ FoodMap - Application .NET MAUI

Application mobile de livraison de nourriture développée avec .NET MAUI, permettant aux utilisateurs de découvrir et commander depuis des restaurants et supermarchés locaux.

## 📱 Aperçu de l'application

### 1. Page de Connexion (LoginPage)
![LoginPage](https://github.com/aliciacmr/FoodMap/blob/master/FoodMap/Resources/Images/screenshots/login_page.jpg)

**Fonctionnalités :**
- Connexion avec email/pseudonyme et mot de passe
- Intégration Facebook Login
- Option de création de compte
- Design épuré avec logo FoodMap

### 2. Permission de Localisation (LocationPermissionPage)
![LocationPermissionPage](https://github.com/aliciacmr/FoodMap/blob/master/FoodMap/Resources/Images/screenshots/location_permission.jpg)

**Fonctionnalités :**
- Demande d'autorisation de localisation
- Option "Ne plus me demander"
- Interface simple et claire

### 3. Page d'Accueil (HomePage)
![HomePage](https://github.com/aliciacmr/FoodMap/blob/master/FoodMap/Resources/Images/screenshots/home_page.jpg)

**Fonctionnalités :**
- Header avec nom d'utilisateur (Alex)
- Menu hamburger
- Panier avec badge de notification
- Cartes de catégories (Super marché, Restaurant)
- Barre de navigation inférieure avec 5 icônes

### 4. Détails du Restaurant (RestaurantDetailPage)
![RestaurantDetailPage](https://github.com/aliciacmr/FoodMap/blob/master/FoodMap/Resources/Images/screenshots/restaurant_detail.jpg)

**Fonctionnalités :**
- Carrousel d'images du restaurant
- Informations détaillées (cuisine, commande minimum, note)
- Bouton MAP pour la localisation
- Liste des items du menu avec bouton d'ajout au panier
- Notation avec étoiles (4.2/5)

## 🎨 Design

### Palette de couleurs
- **Violet principal :** `#3A2A97`
- **Vert (header/boutons) :** `#B6D4B0`
- **Rouge (accents) :** `#DB462E`
- **Background :** `#FFFFFF`
- **Texte :** `#280374` / `#000000`

### Typographie
- **Police principale :** Roboto
- **Logo :** Arial
- **Coins arrondis :** 12px

## 🚀 Structure du Projet

```
FoodMapApp/
│
│── LoginPage.xaml.cs
│── LoginPage.xaml
│── LocationPermissionPage.xaml
│── LocationPermissionPage.xaml.cs
│── HomePage.xaml
│── HomePage.xaml.cs
│── RestaurantDetailPage.xaml
│── RestaurantDetailPage.xaml.cs
├── AppShell.xaml
├── AppShell.xaml.cs
└── Resources/
    └── Images/
        ├── logo_foodmap.jpg
        ├── supermarket.jpg
        ├── restaurant.jpg
        └── restaurant_detail.jpg
```

## 📦 Installation

### Prérequis
- .NET 8.0 ou supérieur
- Visual Studio 2022 (17.8+) avec workload .NET MAUI
- SDK Android / iOS selon la plateforme cible

### Étapes d'installation

1. **Cloner le repository**
   ```bash
   git clone https://github.com/MANKOLLO-LEMBE-Alicia-Colette/foodmap.git
   cd foodmap-app
   ```

2. **Ajouter les images**
   Placez les images suivantes dans `Resources/Images/` :
   - `logo_foodmap.jpg`
   - `supermarket.jpg`
   - `restaurant.jpg`
   - `restaurant_detail.jpg`

3. **Restaurer les packages NuGet**
   ```bash
   dotnet restore
   ```

4. **Compiler et exécuter**
   ```bash
   dotnet build
   dotnet run
   ```

## 🔄 Flux de Navigation

```
LoginPage 
    ↓ (Clic sur "Se connecter")
LocationPermissionPage 
    ↓ (Clic sur "Accepter")
HomePage 
    ↓ (Clic sur "Restaurant")
RestaurantDetailPage
```

## 🏗️ Architecture

### Data Binding
L'application utilise le pattern MVVM simplifié avec data binding :

**HomePage** :
- `ObservableCollection<CategoryItem>` pour les catégories
- Binding dynamique avec `CollectionView`

**RestaurantDetailPage** :
- `Restaurant` pour les informations du restaurant
- `ObservableCollection<MenuItem>` pour le menu
- Binding avec `BindableLayout`



## 🎯 Fonctionnalités implémentées

✅ Navigation Shell entre les pages  
✅ Data binding avec ObservableCollection  
✅ Interface responsive  
✅ Design pixel-perfect selon les maquettes  
✅ Gestion des événements (tap, click)  
✅ Carrousel d'images avec indicateurs  

## 📝 À implémenter

- [ ] Authentification réelle avec API
- [ ] Intégration Facebook Login
- [ ] Géolocalisation avec Google Maps
- [ ] Gestion du panier
- [ ] Système de paiement
- [ ] Historique des commandes
- [ ] Profil utilisateur

## 🛠️ Technologies utilisées

- **.NET MAUI** - Framework multiplateforme
- **C#** - Langage de programmation
- **XAML** - Interface utilisateur
- **Shell Navigation** - Navigation de l'application
- **Data Binding** - Liaison de données



## 📄 Licence

Ce projet est un exemple éducatif développé pour démontrer les capacités de .NET MAUI.

---

**Développé avec ❤️ en .NET MAUI Par MANKOLLO LEMBE Alicia Colette**