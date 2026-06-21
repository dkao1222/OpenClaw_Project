# Scoring System Spec

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: scoring, system, spec

### 範圍
- Scoring System 只負責 survival、near miss、combo、boost multiplier 與 best score 更新，不負責 HUD 版面或碰撞判定。

### 決策
- 分數事件必須可追蹤來源，combo 中斷條件要明確，best score 只在 run end 後更新。

### 交接重點
- 驗收標準是每個分數來源都有公式、觸發條件、上限與 HUD 顯示事件，QA 能用短局重現。

## English

required keywords: scoring, system, spec

### Scope
- The Scoring System owns survival points, near misses, combo, boost multiplier, and best score updates; it does not own HUD layout or collision detection.

### Decisions
- Score events must be attributable, combo break conditions must be explicit, and best score updates only after run end.

### Handoff Notes
- Acceptance requires each scoring source to define formula, trigger, cap, and HUD event so QA can reproduce it in a short session.
