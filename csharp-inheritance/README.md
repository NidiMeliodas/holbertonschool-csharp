# C# Inheritance

## 📚 Learning Objectives

À la fin de ce projet, vous serez capable d'expliquer, sans assistance externe :

- ✅ Ce qu'est l'héritage en C#
- ✅ Comment le polymorphisme est réalisé via l'héritage
- ✅ Ce qu'est une classe de base
- ✅ Ce qu'est une classe dérivée
- ✅ Comment créer une classe dérivée
- ✅ Comment redéfinir (`override`) une méthode ou une propriété héritée
- ✅ La différence entre les modificateurs `override` et `new`
- ✅ Utilisation et différences entre : `is`, `.GetType()`, `typeof()`, `.IsInstanceOfType()`, et `.IsSubclassOf()`

---

## ⚙️ Requis Techniques

- ✅ Éditeur autorisé : Visual Studio Code
- ✅ Compilation : Ubuntu 20.04 LTS avec `dotnet`
- ✅ Tous les fichiers doivent être documentés (XML pour les membres publics)
- ✅ Les fichiers `Program.cs` doivent être renommés selon le nom donné dans chaque tâche
- ✅ Aucun espace de noms (`namespace`) ne doit être utilisé
- ✅ Chaque tâche doit avoir son propre dossier et son propre fichier `.csproj`
- ✅ Les dossiers `obj/` et `bin/` ne doivent **pas** être poussés dans le dépôt
- ✅ Des fichiers `main.cs` sont fournis uniquement à titre de test ; ils ne seront pas utilisés lors de la correction

---

## 🗂️ Structure du Projet

```
├── 0-base-class/
│   ├── 0-base-class.cs
│   ├── 0-base-class.csproj
│   └── README.md (à la racine du projet)
├── 1-derived-class/
│   ├── 1-derived-class.cs
│   └── 1-derived-class.csproj
...
```

---

## 📝 Documentation

- Toutes les **classes et membres publics** doivent inclure des **commentaires XML** (`///`)
- Tous les **éléments privés** doivent également être documentés, mais sans balises XML

---

## 🚀 Compilation et Tests

Pour compiler un projet :

```bash
dotnet build
```

Pour exécuter un projet :

```bash
dotnet run
```

Utilisez les fichiers `main.cs` fournis pour tester localement, mais **ne les poussez pas** sur le dépôt GitHub.

---

## ✅ Bonnes pratiques

- Respectez l’architecture du projet.
- N’utilisez pas de `namespace`.
- Assurez-vous que vos classes soient bien nommées, documentées et testées.

---

## 📎 Liens utiles

- [Documentation officielle Microsoft sur l’héritage](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance)
- [XML documentation comments](https://learn.microsoft.com/en-us/dotnet/csharp/codedoc)

---

> Ce projet est une étape importante pour comprendre la programmation orientée objet en C#.
