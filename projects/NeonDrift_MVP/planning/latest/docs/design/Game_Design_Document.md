# Game Design Document

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: game, design, document

### 範圍
- MVP 範圍是 iPhone-first 單人 NeonDrift 短局遊戲：主選單、開始、漂移操控、速度風險、分數、碰撞失敗、重試與基本設定。

### 決策
- 核心循環是 Start Run -> 左右操控漂移 -> 避開障礙與維持賽道線 -> 以存活時間、近距離閃避與穩定控制累積分數 -> failure -> Retry；Compatibility Matrix 必須涵蓋 iOS 15+、iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro、Android 10+ 代表機與 WebGL desktop browser。

### 交接重點
- 開發交接必須保留 HUD、安全區、觸控目標、視覺可讀性、音效/haptics 觸發、失敗原因、aspect ratio、performance budget 與 acceptance criteria，不能只交概念描述。

## English

required keywords: game, design, document

### Scope
- The MVP scope is an iPhone-first single-player NeonDrift short-session game: main menu, start, drift control, speed risk, score, collision failure, retry, and basic settings.

### Decisions
- The core loop is Start Run -> steer drifting -> avoid hazards and stay readable on the racing line -> score through survival time, near misses, and control consistency -> failure -> Retry; the Compatibility Matrix must cover iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, representative Android 10+ devices, and WebGL desktop browsers.

### Handoff Notes
- The development handoff must preserve HUD, safe areas, touch targets, visual readability, audio/haptics triggers, failure reasons, aspect ratio, performance budget, and acceptance criteria instead of concept-only prose.