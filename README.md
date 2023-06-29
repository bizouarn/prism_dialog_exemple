# Prism Dialog Exemple [![codebeat badge](https://codebeat.co/badges/213b0f32-fb6d-4e6b-8252-d1970e16bcee)](https://codebeat.co/projects/gitlab-com-bizouarn-prism_dialog_exemple-main)

Il s'agit d'un exemple d'utilisation du modèle de conception Dialog MVVM dans le framework Microsoft Prism.

## Description

Ce projet démontre comment utiliser le modèle de conception Dialog MVVM dans le cadre du framework Prism pour développer des applications en C#. Le modèle de conception Dialog MVVM permet de gérer facilement les boîtes de dialogue et les interactions utilisateur dans une application Prism.

## Fonctionnalités

- Affichage d'une boîte de dialogue modale
- Communication entre la boîte de dialogue et la vue principale à l'aide du modèle de vue (ViewModel)
- Utilisation des commandes Prism pour gérer les interactions utilisateur

## Prérequis

Avant de pouvoir exécuter ce projet, assurez-vous d'avoir les éléments suivants installés :

- Microsoft Visual Studio
- Le framework Prism
- Le runtime .NET

## Installation

1. Clonez ce référentiel sur votre machine locale.
2. Ouvrez le fichier de solution `FullApp1.sln` dans Microsoft Visual Studio.
3. Restaurez les packages NuGet nécessaires au projet.
4. Compilez et exécutez le projet.

## Utilisation

Une fois le projet exécuté, vous devriez voir une fenêtre principale avec un bouton. Cliquez sur le bouton pour afficher une boîte de dialogue modale. La boîte de dialogue affichera un message et un bouton de fermeture. Lorsque vous cliquez sur le bouton de fermeture, la boîte de dialogue se ferme et renvoie le contrôle à la fenêtre principale.

Vous pouvez consulter le code source du projet pour voir comment les boîtes de dialogue sont gérées à l'aide du modèle de conception Dialog MVVM et du framework Prism.