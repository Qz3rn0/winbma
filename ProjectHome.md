# WinBMA #



**Download Latest Version** (<span>2.0.4713.34518</span>): http://code.google.com/p/winbma/downloads/detail?name=WinBMA_2.0.4713.34518_Setup.exe

**Checkout Source**: `svn checkout http://winbma.googlecode.com/svn/tags/2.0.4713.34518/ winbma-2.0.4713.34518`

<font color='blue'><b>Note:</b> In order to simplify releasing new versions, source is available through SVN only. For an easy way to checkout from SVN, use <a href='http://tortoisesvn.net/'>TortoiseSVN</a>.</font>

## Description ##

WinBMA is a Windows based Battle.net Authenticator which allows people who don't have access to a smartphone supported by the official BMA to still be protected by an authenticator.

<img src='http://i.imgur.com/etV0Z.png' />

WinBMA supports multiple authenticators. You can save your authenticators to ".bma" files which can be imported again if you need to transfer an authenticator from one computer to the other.

<font color='red'><b>Important:</b> Using this authenticator on the same computer as your WoW installation does <b>NOT</b> protect you against malicious software stealing your information. For maximum security, use this authenticator on a different computer then your WoW installation. See <b>Security Implications</b>.</font>

## Features ##

  * Supports multiple BMA's
  * BMA's can be identified with a label of your choice
  * Auto/Manual resync with Blizzard's Auth servers (once a week)
  * Import and export BMA through the .bma file format
  * One-Click Copy of generated key and serial
  * Strong Encryption Options (AES-256/PBKDF2 and/or Windows Data Protection)
  * **Restore Codes supported**
  * Themes

## Themes ##

<img src='http://i.imgur.com/etV0Z.png' /> <img src='http://i.imgur.com/3Cr0R.png' /> <img src='http://i.imgur.com/0OZNW.png' />

## Security Implications ##

Using a PC based authenticator versus a mobile or hardware one does not protect you against malicious software. Since the security token has to be stored on your computer, malicious software could steal that information and generate working authenticator codes.

This is the reason why Blizzard does not release a PC authenticator. The high-visibility of an official PC authenticator would make it completely useless at stopping malware-based attacks.

However, this does not mean that using a Windows-based authenticator is completely useless. An authenticator protects you on multiple levels:

  1. It almost completely neutralizes and prevents brute-force attacks.
  1. It protects you against data mining from other account compromises (a strong, unique password for each of your accounts also does that, never use the same password twice).
  1. It protects you against common phishing attacks (however, an attacker could request 2 authenticator codes and unregister your current authenticator)
  1. It protects you against keyloggers and malware

This authenticator does all of the above **EXCEPT** point 4 when WinBMA is installed on the same computer as your WoW installation. While it will protect you against _generic_ keyloggers, malware written specifically for stealing WoW account information could include support for WinBMA and steal your authenticator unencrypted security token and generate working authenticator codes for your account. **To mitigate this, please encrypt your tokens using a password** (different than your Battle.net account password).

**For maximum security**, please use an official hardware/mobile authenticator or use the above authenticator on a separate computer then your WoW installation.