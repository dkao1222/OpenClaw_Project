# Development Ready Spec Package

## 繁體中文

- MVP 範圍鎖定為單人 mobile neon drift prototype：開始、遊玩、失敗、分數、重試與基本設定。
- 開發任務應拆成 project shell、core loop、UI/HUD、visual audio feedback、QA pass 與 final package。
- Acceptance criteria / 完成標準是玩家能在手機上完成一輪短局、理解失敗原因、看到分數回饋，並可立即重試。
- Source gate: Operation_Flow_Diagram.md、Prototype_Flow_Canvas.html、Game_Systems_Overview.md、Game_Design_Document.md 必須通過規格標記，development 不可使用舊版籠統 planning。
- Compatibility Matrix: MVP 以 iPhone-first 為主，最低 iOS 15+，必測 iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro；次要驗證 Android 10+ 代表機與 WebGL desktop browser，並記錄 aspect ratio 與 performance budget。

## English

- The MVP scope is a single-player mobile neon drift prototype covering start, play, failure, score, retry, and basic settings.
- Implementation should be split into project shell, core loop, UI/HUD, visual-audio feedback, QA pass, and final package.
- Acceptance criteria: a mobile player can finish a short run, understand failure, see score feedback, and retry immediately.
- Source gate: Operation_Flow_Diagram.md, Prototype_Flow_Canvas.html, Game_Systems_Overview.md, and Game_Design_Document.md must pass required markers; development must not use older vague planning.
- Compatibility Matrix: the MVP is iPhone-first with minimum iOS 15+, required checks on iPhone SE 2/3, iPhone 12/13 mini, and iPhone 15/15 Pro; secondary checks cover representative Android 10+ devices and WebGL desktop browsers, with aspect ratio and performance budget recorded.
