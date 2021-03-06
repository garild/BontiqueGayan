; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{BAD44E56-5FC7-4F88-80D9-F07E0C12D045}
AppName=BoutiqueShopp
AppVersion=1.0.0.1
VersionInfoVersion=1.0.0.1
AppPublisher=BoutiqueShopp
DefaultDirName={pf}\BoutiqueShopp\
DefaultGroupName=BoutiqueShopp
DisableProgramGroupPage=true
OutputDir=D:\GitRepo\BontiqueGayane\
OutputBaseFilename=BoutiqueShopp
SetupIconFile=D:\GitRepo\BontiqueGayane\src\BoutiqueShopp\Instalator\BontiqueShopp.ico
Compression=lzma/ultra
SolidCompression=true
InternalCompressLevel=ultra

[Languages]
Name: polish; MessagesFile: compiler:Languages\Polish.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}

[Files]
Source: ..\bin\Debug\AC.ExtendedRenderer.Toolkit.dll; DestDir: {app}; Flags: 32bit replacesameversion
Source: ..\bin\Debug\ComponentFactory.Krypton.Toolkit.dll; DestDir: {app}; Flags: 32bit replacesameversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: ..\bin\Debug\BoutiqueShopp.exe; DestDir: {app}; Flags: replacesameversion; Tasks: " desktopicon"
Source: ..\bin\Debug\FluentValidation.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\MetroFramework.Design.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\MetroFramework.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\MetroFramework.Fonts.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\BoutiqueShopp.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\DapperExtensions.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Autofac.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Krypton Toolkit.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Krypton Wizard.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\..\Infrastructure\Database\bin\Debug\BoutiqueShopp.dacpac; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\WinFormAnimation.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Newtonsoft.Json.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\NaviSuite.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Global Utilities.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Microsoft.SqlServer.Types.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Microsoft.SqlServer.TransactSql.ScriptDom.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Microsoft.SqlServer.Dac.Extensions.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Microsoft.SqlServer.Dac.dll; DestDir: {app}; Flags: replacesameversion
Source: ..\bin\Debug\Microsoft.Data.Tools.Utilities.dll; DestDir: {app}; Flags: replacesameversion                                                                                       
Source: ..\bin\Debug\Microsoft.Data.Tools.Schema.Sql.dll; DestDir: {app}; Flags: replacesameversion                                                                                       
                          

[Icons]
Name: {group}\BoutiqueShopp; Filename: {app}\BoutiqueShopp.exe; IconIndex: 0; WorkingDir: {app};
Name: {commondesktop}\BoutiqueShopp; Filename: {app}\BoutiqueShopp.exe; IconIndex: 0
[Run]
Filename: {app}\BoutiqueShopp.exe; Flags: postinstall unchecked runascurrentuser
Filename: ie4uinit.exe; Parameters: -ClearIconCache; StatusMsg: Od�wie�anie pulptiu; Flags: skipifdoesntexist runascurrentuser
