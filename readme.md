## What is Modern.Forms?

*** **This is currently a proof of concept. It is not intended for production use.** ***

Modern.Forms is a cross-platform spiritual successor to Winforms for .NET Core 3.0+.

**This is accomplished with:**

* .NET Core 3.0+
* Some infrastructure code from Mono's Winforms (like layouts):
  * https://github.com/mono/mono/tree/master/mcs/class/System.Windows.Forms
* A port of Avalonia's native backends
  * https://github.com/AvaloniaUI/Avalonia
  * Only the base infrastructure is used, basically this gives us a blank Form
* SkiaSharp
  * New controls drawn with SkiaSharp

### Motivation

The goal of this proof of concept is to create a spiritual successor to Winforms that is:
* Cross platform (Windows / Mac / Linux)
* Familiar for Winforms developers (ie: not XAML)
  * Sample Form:
    * [MainForm.cs](https://github.com/jpobst/Modern.Forms/blob/master/samples/Explorer/MainForm.cs)
    * [MainForm.Designer.cs](https://github.com/jpobst/Modern.Forms/blob/master/samples/Explorer/MainForm.Designer.cs)
* Great for LOB applications and quick apps
* Updated with modern controls and modern aesthetics

## Build Status

Windows | Mac - High Sierra | Ubuntu 16.04
-|-|-
[![Build status](https://dev.azure.com/jonathan0207/Modern.Forms/_apis/build/status/Windows)](https://dev.azure.com/jonathan0207/Modern.Forms/_build/latest?definitionId=1) | [![Build status](https://dev.azure.com/jonathan0207/Modern.Forms/_apis/build/status/Mac%20OSX%20-%20High%20Sierra)](https://dev.azure.com/jonathan0207/Modern.Forms/_build/latest?definitionId=4) | [![Build status](https://dev.azure.com/jonathan0207/Modern.Forms/_apis/build/status/Ubuntu%2016.04)](https://dev.azure.com/jonathan0207/Modern.Forms/_build/latest?definitionId=2)

## How to Run

### Windows

* Clone this repository
* Install .NET Core 3.0+
  * https://dotnet.microsoft.com/download/dotnet-core
* Open `Modern.Forms.sln` in Visual Studio 2019
* Ensure `Explore` is set as the Startup project
* Hit F5

![Windows Screenshot](https://github.com/jpobst/Modern.Forms/blob/master/docs/explorer-windows.png "Windows Screenshot")

### Ubuntu 19.04 AMD64

* Clone this repository
* Install .NET Core 3.0+
  * https://dotnet.microsoft.com/download/dotnet-core
* Navigate to `samples/Explorer`
* Run `dotnet run`

![Ubuntu Screenshot](https://github.com/jpobst/Modern.Forms/blob/master/docs/explorer-ubuntu.png "Ubuntu Screenshot")

### Mac OSX

* Clone this repository
* Install .NET Core 3.0+
  * https://dotnet.microsoft.com/download/dotnet-core
* Navigate to `samples/Explorer`
* Run `dotnet run`

![OSX Screenshot](https://github.com/jpobst/Modern.Forms/blob/master/docs/explorer-osx.png "Mac Screenshot")
