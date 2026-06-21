# Feedback System Spec

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: feedback, system, spec

### 範圍
- Feedback System 只負責 HUD、SFX、haptics、camera response 與 VFX 事件映射，不改變核心玩法狀態。

### 決策
- Start、drift、boost、near miss、score tick、collision、retry 都必須有對應 feedback event，且 reduced motion 有降級方案。

### 交接重點
- 驗收標準是 feedback 不遮擋車體、障礙或 HUD，haptics 僅用於 collision 與高價值事件。

## English

required keywords: feedback, system, spec

### Scope
- The Feedback System owns HUD, SFX, haptics, camera response, and VFX event mapping without changing core gameplay state.

### Decisions
- Start, drift, boost, near miss, score tick, collision, and retry must each have a feedback event, with a reduced-motion fallback.

### Handoff Notes
- Acceptance requires feedback not to obscure the vehicle, hazards, or HUD, and haptics only for collision and high-value events.
