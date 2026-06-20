# MVP QA Test Plan

## 繁體中文

- 測試 Unity scene load、左右觸控/鍵盤控制、障礙碰撞、分數增加、失敗狀態、Retry 與不同長寬比顯示。
- 相容性目標是 iOS、Android、WebGL；本 runner 會偵測 Unity Editor，缺少 Editor 時會在 validation report 標示 skipped reason。
- Compatibility Matrix: primary iOS 15+ checks include iPhone SE 2/3 compact safe area, iPhone 12/13 mini narrow aspect, and iPhone 15/15 Pro Dynamic Island/notch safe area; secondary checks include Android 10+ representative phone and WebGL desktop browser.
- Performance budget: gameplay target 60 FPS on modern iPhone, acceptable 30 FPS floor on low-tier devices, no HUD overlap across 16:9, 19.5:9, compact SE, and desktop browser aspect ratios.

## English

- Test Unity scene load, left/right touch or keyboard steering, hazard collision, score increase, failure state, Retry, and multiple aspect ratios.
- Compatibility targets are iOS, Android, and WebGL; this runner detects Unity Editor and records a skipped reason when the Editor is unavailable.
- Compatibility Matrix: primary iOS 15+ checks include iPhone SE 2/3 compact safe area, iPhone 12/13 mini narrow aspect, and iPhone 15/15 Pro Dynamic Island/notch safe area; secondary checks include a representative Android 10+ phone and WebGL desktop browser.
- Performance budget: gameplay targets 60 FPS on modern iPhone, allows a 30 FPS floor on low-tier devices, and must avoid HUD overlap across 16:9, 19.5:9, compact SE, and desktop browser aspect ratios.
