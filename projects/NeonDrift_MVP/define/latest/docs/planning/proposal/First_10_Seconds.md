# Proposal Card: First 10 Seconds

## 繁體中文

### 開局 10 秒
- First 10 Seconds 是 playable proof，不是教學文字。Start 後玩家必須看到 menu 消失、vehicle 出現、track/background motion、hazard preview、boost cell、score/pulse 變化。
- 目標是讓第一次玩的玩家在 10 秒內知道：左右按鍵會改變 drift lane，magenta 物件要躲，cyan/yellow 物件可收集，pulse 下降會造成風險。

### 事件時間線
- 0 到 3 秒：Start button 被點擊後，overlay 離場，vehicle 進入可玩區，track speed line 或 parallax 開始動，第一個 hazard preview 或 boost cell 進入畫面上方。
- 4 到 7 秒：玩家 tap left/right 時，button highlight、vehicle lateral movement、trail direction、score/combo/pulse 至少兩項改變；若沒有輸入，畫面要出現 left/right drift hint 而不是直接 passive death。
- 8 到 10 秒：第二個 hazard 或 boost tradeoff 出現，讓玩家做一次風險選擇；如果玩家撞到 hazard 或 pulse 太低，failure reason 必須與畫面事件一致。

### QA 證據
- QA video 至少要截到 Start 前、Start 後 3 秒、第一次 left/right input、第一次 hazard/boost interaction、game over、retry 後 3 秒。
- QA log/runtime probe 需要能讀到 run_state、score、pulse、current_lane、hazard_count、boost_count、last_failure_reason。
- 不合格條件：黑屏、空場景、純背景得分、按 Start 沒反應、按 left/right 無 visible delta、pulse 自動扣到 0 但玩家沒有可理解操作目標。

## English

### First 10 Seconds
- First 10 Seconds is playable proof: after Start the menu exits, the vehicle appears, track/background motion begins, hazards/boosts appear, and score/pulse changes are visible.

### Event Timeline
- 0 to 3 seconds: Start, overlay exits, vehicle enters, motion begins, first hazard preview or boost appears. 4 to 7 seconds: left/right input changes button, vehicle, trail, score/combo, or pulse. 8 to 10 seconds: a hazard or boost tradeoff forces a decision.

### QA Evidence
- QA must record before Start, gameplay, first input, first interaction, game over, and after retry. Black screen, empty scene, static input, or passive death fails.

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
