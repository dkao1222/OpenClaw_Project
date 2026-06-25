# Narrative Experience Brief

## 繁體中文

### 玩家幻想
- 玩家是夜間資料高速道上的霓虹漂移駕駛，任務是在過載脈衝中保持控制並突破危險節點。
- 幻想重點不是完整劇情，而是讓車體、障礙、boost、combo、失敗與 retry 都像同一個世界的一部分。

### 世界前提
- NeonDrift 發生在會崩解的城市光軌，賽道脈衝代表系統穩定度，hazard 是阻斷路徑的故障訊號。
- 第一畫面必須讓玩家感覺進入一條危險但可掌控的光軌，而不是抽象方塊測試場。

### 畫面敘事物件
- Player vehicle、hazard shard、boost cell、combo pulse、failure flash、retry surge 都必須有視覺身份與用途差異。
- 標題、HUD、危險色、獎勵色、音效與 VFX 要支援同一個高速光軌幻想。

### 失敗與重試意義
- 失敗代表 drift pulse 崩解或撞上 hazard shard，failure screen 要說明可改善的原因。
- Retry 代表重新同步光軌，不是回到空白狀態；畫面應有可見 recovery cue。

## English

### Player Fantasy
- The player is a neon drift pilot on a night data expressway, trying to keep control through overload pulses and dangerous nodes.
- The fantasy is not long lore; it makes the vehicle, hazards, boost, combo, failure, and retry feel like one coherent world.

### World Premise
- NeonDrift takes place on a collapsing city light-track where pulse represents system stability and hazards are route-blocking fault signals.
- The first screen must feel like a dangerous but controllable light-track, not an abstract block prototype.

### Visual Storytelling Objects
- Player vehicle, hazard shard, boost cell, combo pulse, failure flash, and retry surge must each have a distinct visual identity and purpose.
- Title, HUD, danger color, reward color, audio, and VFX must support the same high-speed light-track fantasy.

### Failure and Retry Meaning
- Failure means the drift pulse collapsed or the player hit a hazard shard, and the failure screen must explain the improvable cause.
- Retry means re-syncing the light-track, not returning to a blank state; the screen needs a visible recovery cue.

## Reasoning and Tradeoffs

- selected approach: use compact visual storytelling instead of long lore so art, UI, gameplay, and QA share one fantasy.
- rejected alternatives: generic cyber-neon theme words, cutscene-first storytelling, or lore that is invisible in gameplay.
- why selected: the current product has repeatedly looked like a prototype, so narrative must force visible identity into player/threat/reward/failure assets.
- acceptance evidence: QA must identify player role, threat, reward, failure meaning, and retry meaning from screenshots/video without reading runtime JSON.
- risks if wrong: if narrative stays only in docs, art direction can still produce the same colored rectangles and claim compliance.
- downstream owner: ui-ux-designer owns visible first-screen cue; technical-artist owns visual identity; QA owns screenshot/video evidence.
- source_paths: docs/planning/Visual_Richness_Target.md, docs/planning/Gameplay_Depth_Target.md, docs/product/MVP_PRD.md, knowledge_base/narrative_design/ROUTING.md.
