# MVP QA Test Plan

## 繁體中文

- 測試 Unity scene load、左右觸控/鍵盤控制、障礙碰撞、分數增加、失敗狀態、Retry 與不同長寬比顯示。
- 相容性目標是 iOS、Android、WebGL；本 runner 會偵測 Unity Editor，缺少 Editor 時會在 validation report 標示 skipped reason。

## English

- Test Unity scene load, left/right touch or keyboard steering, hazard collision, score increase, failure state, Retry, and multiple aspect ratios.
- Compatibility targets are iOS, Android, and WebGL; this runner detects Unity Editor and records a skipped reason when the Editor is unavailable.
