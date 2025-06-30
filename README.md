📦 TorrentCast v1.0 — Initial Release

TorrentCast is a simple Windows desktop application for managing .torrent files and automating their upload to an FTP server after processing. It’s a self-contained WinForms app built in C# targeting .NET Framework 4.8.

I wrote it to speed up my own workflow — mainly to avoid wasting time logging into my seedbox's web UI or using FileZilla every time I want to upload torrents. I personally use it to send files to an RTorrent seedbox, where AutoTools picks them up automatically for downloading. It should also work fine with any other seedbox setup that watches a folder for new .torrent files.
🛠️ Features:

    Simple WinForms-based GUI

    Automatically moves .torrent files into an "active" folder for processing

    Successfully uploaded or failed torrents are moved to separate archive/retry folders

    Configuration is stored in JSON, with the FTP password encrypted using your machine’s hardware ID

    Lightweight and portable — no installation required

⚠️ Antivirus Note:

This app is unsigned and not packaged in an installer, so a couple of antivirus engines (mostly obscure ones) may flag it as suspicious. It's a false positive caused by heuristics, not malware.

You can check the current VirusTotal scan here:
🔗 View on VirusTotal https://www.virustotal.com/gui/file/87560ca66c7ff7e70f7c97c242d9e87d7b36b5f77ea771fa9bada1872aab7651/detection/f-87560ca66c7ff7e70f7c97c242d9e87d7b36b5f77ea771fa9bada1872aab7651-1751290845
