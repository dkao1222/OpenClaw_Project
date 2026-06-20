# Game Systems Overview

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: game, systems, overview

### 範圍
- 系統範圍鎖定六個 MVP 系統：Control System、Speed System、Hazard System、Scoring System、Failure/Retry System、Feedback System；不加入帳號、多人、商店或長線任務。

### 決策
- 每個系統必須定義 input、state、rule、output、dependency：Control 讀取左右觸控並輸出 drift intent；Speed 依存活時間與 boost state 提升速度；Hazard 依速度調整生成密度；Scoring 依 survival、near miss、combo 累積分數；Failure/Retry 依 collision/off-line state 進入結果畫面；Feedback 依 scoring/failure event 觸發 HUD、SFX、haptics。

### 交接重點
- 驗收標準是開發者可逐一實作並測試六個系統：每個系統都有明確成功條件、失敗條件、跨系統依賴、可觀察 UI/HUD 輸出與 spec review 待細化項。

## English

required keywords: game, systems, overview

### Scope
- The MVP system scope is limited to six systems: Control System, Speed System, Hazard System, Scoring System, Failure/Retry System, and Feedback System; accounts, multiplayer, shop, and long-term quest systems are out of scope.

### Decisions
- Each system must define input, state, rule, output, and dependency: Control reads left/right touch and outputs drift intent; Speed increases from survival time and boost state; Hazard adjusts spawn density from speed; Scoring accumulates survival, near miss, and combo points; Failure/Retry enters results from collision/off-line state; Feedback triggers HUD, SFX, and haptics from scoring/failure events.

### Handoff Notes
- Acceptance requires developers to implement and test the six systems independently: each system has explicit success conditions, failure conditions, cross-system dependencies, observable UI/HUD output, and spec review items that still need detail.
