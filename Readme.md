# Native Function Hook (Lib)

This is the main development repository of Native Function Hook. The current plan is make mission scripts et cetera. native functions. Originally, it's developed under [Landtory](http://github.com/RelaperCrystal/Landtory) project. 

This project was aiming for full implement on documented natives and these natives I discovered. The untested & usage unknown natives and undocumented & undiscovered natives or **documented returns/arguments is not it should be**. Be advised this project was not a replacement for LMS' `AdvancedHook`, which aiming for memory hacking. This library is following *object oriented* design principles.

*This project will be maintained but it will not be frequently as it's current deprecated because it was designed for Grand Theft Auto IV.*

## Building

You will require these following tools and libraries:

| Name                        | File Name            | Used for                                         |
| --------------------------- | -------------------- | ------------------------------------------------ |
| .NET Script Hook            | ScriptHookDotNet.asi | Supporting basic function and calling for native |
| Visual Studio 2017 or later | N/A                  | Development Environment                          |
| Grand Theft Auto IV / EFLC  | N/A                  | The Game                                         |

Open the project with Visual Studio, and click `BUILD -> Build Solution` to build the Native Function Hook.

Otherwise you can build with `MSBuild` console, or, use `devenv NativeFunctionHook.sln /Build`.

## Using

This library was licensed under GNU General Public License version 3. Feel free to use this library without violating the license.

## Release

There's no binary releases at this time. The only binary provided is in `Landtory` project and it was using a old version, which is the only needed version, and it is `no longer maintained`.

If you wish to use this library, you can include it in your archive.