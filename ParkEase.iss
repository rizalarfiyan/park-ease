#define HasilCompile "D:\kuliah\semester_3\pemrograman_lanjut\ParkEase\bin\Debug\net7.0-windows"

[Setup]
AppName=Park Ease
AppVerName=Park Ease Versi 1.0.0
AppPublisher=Park Ease Company
AppCopyright=Copyright © 2023. Park Ease Company
DefaultDirName={pf}\Park Ease
DefaultGroupName=Park Ease
OutputDir=file setup
OutputBaseFilename=SetupParkEase
DisableProgramGroupPage = yes
CreateUninstallRegKey = yes
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\ParkEase.exe,0
UninstallDisplayName=Park Ease
VersionInfoVersion=1.0.0.0
SetupIconFile=parking.ico
LicenseFile=License.txt

[Languages]
Name: English; MessagesFile: Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
;file-file aplikasi
Source: {#HasilCompile}\ParkEase.exe; DestDir: {app}; Flags: ignoreversion

; file-file pendukung
Source: {#HasilCompile}\System.Management.dll; DestDir: {app}; Flags: ignoreversion
Source: {#HasilCompile}\System.Reactive.dll; DestDir: {app}; Flags: ignoreversion
Source: {#HasilCompile}\RestSharp.dll; DestDir: {app}; Flags: ignoreversion
Source: {#HasilCompile}\ParkEase.dll; DestDir: {app}; Flags: ignoreversion
Source: {#HasilCompile}\Guna.UI2.dll; DestDir: {app}; Flags: ignoreversion
Source: {#HasilCompile}\ParkEase.runtimeconfig.json; DestDir: {app}; Flags: ignoreversion
Source: {#HasilCompile}\ParkEase.pdb; DestDir: {app}; Flags: ignoreversion
Source: {#HasilCompile}\ParkEase.deps.json; DestDir: {app}; Flags: ignoreversion
Source: {#HasilCompile}\runtimes\win\lib\net7.0\System.Management.dll; DestDir: {app}\runtimes\win\lib\net7.0; Flags: ignoreversion

Source: parking.ico; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: {group}\Park Ease; Filename: {app}\ParkEase.exe; WorkingDir: {app}; IconFilename: {app}\parking.ico
Name: {userdesktop}\Park Ease; Filename: {app}\ParkEase.exe; WorkingDir: {app}; IconFilename: {app}\parking.ico; Tasks: desktopicon

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\Park Ease"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue