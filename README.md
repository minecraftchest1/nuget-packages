# NuGet-Packages

![Nuget](https://img.shields.io/nuget/v/Minecraftchest1-utils)

![Nuget](https://img.shields.io/nuget/dt/Minecraftchest1-utils)

![GitHub Repo stars](https://img.shields.io/github/stars/minecraftchest1/nuget-packages)

![Azure DevOps builds](https://img.shields.io/azure-devops/build/wyattcjackson2006/159577bd-f56f-472e-83f4-a809b466d6d0/1?label=Doxygen%20Build%20Status&logo=Azure%20DevOps)

![Azure DevOps builds](https://img.shields.io/azure-devops/build/wyattcjackson2006/159577bd-f56f-472e-83f4-a809b466d6d0/2?label=Test%20Build%20Status&logo=Azure%20DevOps)

A small collection of simple methods that I have created


Documentation at https://minecraftchest1.github.io/nuget-packages/

## Source code is avaible at

* https://github.com/minecraftchest1/nuget-packages
* https://gitlab.com/minecraftchest1/nuget-packages

# Building

## Required tools

* .Net core 5.0
* Doxygen

## Build steps

Run the build.sh or build.ps1 script in the root of the repository. This will build the project in its subdirectory and place it in its bin folder.

The automatically generated documentation in html format is placed in the html folder in the repro root. Other formats can be found in the Doxygen subfolder in the repro root.

# Changelog

## 1.3.1
 * Add `Exit()` funtion.
 * Add `InputByte()` function.
 * Add `Menu()` function

## 1.2.3

* Add option to customize `pasue()` behavior.
* Fix build.sh script.

## 1.2.2

* Add `ArrayToString` function.

## 1.2.1 

* Change to using Major.Minor.Patch[-Suffix] versioning system.
