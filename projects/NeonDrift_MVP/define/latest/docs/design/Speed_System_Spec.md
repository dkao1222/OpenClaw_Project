# Speed System Spec

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: speed, system, spec

### 範圍
- Speed System 只負責速度曲線、加速壓力與 boost 狀態，輸出目前速度 tier 給 hazard、camera、HUD 與 scoring 使用。

### 決策
- 速度隨存活時間與穩定操控逐步提升，boost 只能短時間提高風險與得分倍率，不能讓障礙可讀性失效。

### 交接重點
- 驗收標準是每個速度 tier 有明確輸入、狀態、上限、重置條件與 performance budget，不允許無限加速。

## English

required keywords: speed, system, spec

### Scope
- The Speed System owns speed curves, pressure escalation, and boost state, outputting the current speed tier to hazard, camera, HUD, and scoring systems.

### Decisions
- Speed increases from survival time and controlled play; boost may briefly raise risk and score multiplier but must not break hazard readability.

### Handoff Notes
- Acceptance requires each speed tier to define input, state, cap, reset condition, and performance budget, with no unlimited acceleration.
