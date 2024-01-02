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

[Code]
var
  WelcomePage: TWizardPage;
  Label_1: TNewStaticText;
  Label_2: TNewStaticText;
  Label_3: TNewStaticText;
  LogoImage: TBitmapImage;

procedure InitializeWizard;
begin
  // Create a welcome page with a simple description
  WelcomePage := CreateCustomPage(wpWelcome, 'Selamat Datang di Proses Instalasi Park Ease!', '');

  // Add additional description text
  Label_1 := TNewStaticText.Create(WelcomePage);
  Label_1.Parent := WelcomePage.Surface;
  Label_1.Left := ScaleX(0);
  Label_1.Top := ScaleY(10);
  Label_1.Width := WelcomePage.SurfaceWidth;
  Label_1.WordWrap := True; // Allow text to wrap within the width
  Label_1.Caption := 'Program ini akan memasang software Park Ease Version 1.0.0 pada perangkat komputer anda.';

  // Add additional description text
  Label_2 := TNewStaticText.Create(WelcomePage);
  Label_2.Parent := WelcomePage.Surface;
  Label_2.Left := ScaleX(0);
  Label_2.Top := ScaleY(50);
  Label_2.Width := WelcomePage.SurfaceWidth;
  Label_2.WordWrap := True; // Allow text to wrap within the width
  Label_2.Caption := 'Klik Next untuk melanjutkan, atau klik Cancel untuk keluar dari proses instalasi.';

  // Add your logo image below the label
  LogoImage := TBitmapImage.Create(WelcomePage);
  LogoImage.Parent := WelcomePage.Surface;
  LogoImage.Left := ScaleX(60);
  LogoImage.Top := ScaleY(80);
  LogoImage.Width := WelcomePage.SurfaceWidth;
  LogoImage.Height := ScaleY(80);
  LogoImage.Bitmap.LoadFromFile(ExpandConstant('C:\22.11.5209\park-ease\logo-park-ease-oranye.bmp'));

  // Add additional description text
  Label_3 := TNewStaticText.Create(WelcomePage);
  Label_3.Parent := WelcomePage.Surface;
  Label_3.Left := ScaleX(0);
  Label_3.Top := ScaleY(180);
  Label_3.Width := WelcomePage.SurfaceWidth;
  Label_3.WordWrap := True; // Allow text to wrap within the width
  Label_3.Caption := 'Dengan mengikuti langkah-langkah sederhana ini, Anda akan segera dapat menikmati fitur-fitur canggih dari Park Ease.';
end;