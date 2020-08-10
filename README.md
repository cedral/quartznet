# Quartz.NET - Job Scheduler for the .NET Platform

The original can be found here [http://www.quartz-scheduler.net/](http://www.quartz-scheduler.net/)

## Introduction

This is the README file for my custom 3.0.x version of Quartz.NET. The purpose of this fork is to keep .net 4.6 comapitibility for server 2008 and avoid the additional netstandard2.0 dependencies and related remappings required for quarts 3.1. The fixes for 3.1 that didn't add dependencies were cherry-picked for this releaese. unit tests are passing.

## Installation

* Stable builds from NuGet: https://www.nuget.org/packages?q=id%3Asouthwell

## Building

* You can build the code by running `build.cmd` (Windows) or `build.sh` (*nix platform)
* You need MSBuild 16 and .NET Core SDK 3.1 to build - easiest to [download Visual Studio 2019 Community](https://www.visualstudio.com/downloads/)
* You need Visual Studio 2019 to open the solution, [Community version](https://www.visualstudio.com/downloads/) should suffice

## Acknowledgements

Following components are being used by core Quartz:

* [LibLog](https://github.com/damianh/LibLog) (MIT) as bridge between different logging frameworks


## License

Licensed under the Apache License, Version 2.0 (the "License"); you may not 
use this file except in compliance with the License. You may obtain a copy 
of the License [here](http://www.apache.org/licenses/LICENSE-2.0).

For API documentation, please refer to [Quartz.NET site](http://quartznet.sourceforge.net/apidoc/3.0/html/).
