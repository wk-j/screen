## Screen

[![Build Status](https://dev.azure.com/wk-j/screen/_apis/build/status/wk-j.screen?branchName=master)](https://dev.azure.com/wk-j/screen/_build/latest?definitionId=24&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/wk.Screen.svg)](https://www.nuget.org/packages/wk.Screen)

Execute command in another Terminal

## Installation

```bash
dotnet tool install -g wk.Screen
```

## Usage

Terminal 1

```bash
wk-screen -i
wk-screen --init
```

Terminal 2

```bash
wk-screen -c ls
wk-screen --command ls
```