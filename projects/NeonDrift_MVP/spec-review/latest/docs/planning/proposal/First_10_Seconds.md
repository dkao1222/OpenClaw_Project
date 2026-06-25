# Proposal Card: First 10 Seconds

## 繁體中文

### 開局 10 秒
- First 10 Seconds 是 playable proof：Start 後看到 menu 消失、vehicle 出現、background movement、hazard preview、boost cell、score/pulse 變化。
### 事件時間線
- 0 到 3 秒：Start、overlay 消失、vehicle 與 first hazard preview/boost cell 出現。4 到 7 秒：left/right input 產生 button highlight、movement、trail change。8 到 10 秒：第二個 hazard 或 boost tradeoff 出現。
### QA 證據
- QA Evidence 需含 Start 前、gameplay、game over、retry 後；影片必須排除黑屏、空場景、無互動、passive pulse depletion。

## English

### First 10 Seconds
- First 10 Seconds is playable proof: after Start, menu disappears, vehicle appears, background moves, hazard preview, boost cell, and score/pulse change appear.
### Event Timeline
- 0 to 3: Start, overlay gone, vehicle and first hazard preview/boost cell appear. 4 to 7: left/right input creates button highlight, movement, and trail change. 8 to 10: second hazard or boost tradeoff appears.
### QA Evidence
- QA Evidence covers before Start, gameplay, game over, and after retry; video must rule out black screen, empty scene, no interaction, and passive pulse depletion.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md, GOOD_BAD_EXAMPLES.md.
- Gameplay depth evidence: player objective, first 10 seconds, risk/reward, combo/boost, failure reason, HUD feedback, and QA evidence are bounded for downstream planning.
- Visual richness evidence: VISUAL_RICHNESS.md defines screen layers, track material, VFX/motion, typography/icon direction, readability, and target-device constraints.
- Blockers: fail if the document only uses unsupported adjectives without measurable implementation evidence without concrete player action, system response, feedback, failure, and QA proof.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_PLANNER_ROLE.md, DESIGN_METHODS.md, VALIDATION_GATES.md.
- GAME_DEV_BLACK_BOOK_REFERENCE.md used: user-centric reverse deduction, MDA mapping, player agency, FTUE, sensory validation, MVP loop, and QA evidence are preserved.
- GDD_STRUCTURE_REFERENCE.md used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan are converted into bounded planning commitments.
- Implementation readiness: downstream agents must receive enough player action, input/state/rule/output, feedback, risk, reset, and acceptance detail to avoid inventing core gameplay during development.
