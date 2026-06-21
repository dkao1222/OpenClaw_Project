# Platform Direction

## 繁體中文

### 平台範圍
- 主要平台是 iOS，先以 iOS simulator/local build 驗證；Android 與 WebGL 作為後續次要目標。
- 相容性優先覆蓋 iOS 15+、iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro，並保留 Android 10+ 代表機與 WebGL desktop browser 檢查。

### 控制方式
- MVP 使用單手左右觸控區域控制 drift，不依賴鍵盤、外接手把或多指複雜手勢。
- UI 必須保留 pause、retry、Start、Settings、Best Score 與清楚的分數/boost/combo HUD。

### 技術限制
- Unity 6000.0.71f1 是鎖定方向；build gate 以本機 Unity batchmode、iOS simulator app、Xcode simulator build 與 deterministic QA evidence 為主。
- 目標 frame pacing 為 60 FPS；必須處理 safe area、notch/Dynamic Island、窄螢幕與低階機效能預算。

## English

### Platform Scope
- iOS is the primary platform and is validated first through iOS simulator/local build; Android and WebGL remain secondary follow-up targets.
- Compatibility starts with iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, with Android 10+ representative devices and WebGL desktop browser checks retained.

### Control Model
- MVP uses one-handed left/right touch zones for drift control and does not depend on keyboard, external controllers, or complex multi-touch gestures.
- UI must preserve pause, retry, Start, Settings, Best Score, and readable score/boost/combo HUD.

### Technical Constraints
- Unity 6000.0.71f1 is the locked direction; the build gate relies on local Unity batchmode, iOS simulator app, Xcode simulator build, and deterministic QA evidence.
- Target frame pacing is 60 FPS; safe area, notch/Dynamic Island, narrow screens, and low-end device performance budgets must be handled.
