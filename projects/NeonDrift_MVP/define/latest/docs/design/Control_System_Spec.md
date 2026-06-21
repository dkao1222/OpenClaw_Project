# Control System Spec

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: control, system, spec

### 範圍
- Control System 只負責讀取左右觸控、維持 drift intent、輸出車體轉向與漂移狀態，不負責分數、障礙生成或 UI 呈現。

### 決策
- 輸入規則是 left zone/right zone 持續按壓控制方向，release 回到中性；所有主要觸控區域必須維持 44x44 pt 以上並避開 safe area。

### 交接重點
- 驗收標準是玩家在 iPhone SE 2/3 與 iPhone 15 上能預測車體反應，失敗原因不可來自隱藏延遲或未標示控制區。

## English

required keywords: control, system, spec

### Scope
- The Control System only reads left/right touch, maintains drift intent, and outputs steering plus drift state; it does not own scoring, hazard spawning, or UI rendering.

### Decisions
- Input rules use sustained press on left and right zones with release returning to neutral; all primary touch zones must remain at least 44x44 pt and avoid safe areas.

### Handoff Notes
- Acceptance requires predictable vehicle response on iPhone SE 2/3 and iPhone 15, with failure never caused by hidden latency or unlabeled control zones.
