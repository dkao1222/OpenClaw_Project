# Phase1 MVP QA Report

## 繁體中文

- 靜態驗證通過：Unity project structure、C# gameplay scripts、scene 與 build runner markers 存在。
- QA pass 不只代表 build 成功；必須同時通過按鍵位置/尺寸/可點擊性、safe area、核心玩法物件、分數、暫停、失敗與重試功能 gate。
- QA pass 需要 repeated playthrough evidence：至少三輪完整單局與重試循環，並依單局時長提供足夠長度的影片，不接受只看第一個 10 秒。
- 限制：若本機沒有 Unity Editor，iOS、Android、WebGL batchmode build 會標示 skipped，不宣稱平台 build completed。

## English

- Static verification passed: Unity project structure, C# gameplay scripts, scene, and build runner markers exist.
- QA pass is not just build success; it also requires button position/size/clickability, safe area, core gameplay objects, scoring, pause, failure, and retry gates.
- QA pass requires repeated playthrough evidence: at least three full single-run and retry cycles, with enough video duration based on single-run length; a first-10-second-only clip is not accepted.
- Limitation: when Unity Editor is unavailable, iOS, Android, and WebGL batchmode builds are marked skipped and platform build completion is not claimed.
