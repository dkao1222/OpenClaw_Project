# Game Proposal

## 繁體中文

### 提案索引
- 本文件只作為 proposal index，不承載全部設計細節；後續 agent 先讀本索引，再按任務讀取對應 context card，避免單一上下文過大。
- Proposal 被拆成高概念、畫面輪廓、開局 10 秒、物件規則、失敗重試、MVP 邊界六張卡；每張卡都能獨立提供 downstream 決策。

### 上下文卡片
- High_Concept.md：鎖定玩家承諾、left/right drift、hazard、boost、combo、pulse 與核心體感。
- Game_Screen_Outline.md：鎖定直式畫面、HUD、安全區、賽道、背景動態與 iPhone SE 可讀性。
- First_10_Seconds.md：鎖定 Start 後 0 到 10 秒事件，避免空場景、黑屏、被動掉 pulse。
- Primary_Objects_and_Rules.md：鎖定 Player vehicle、Hazard、Boost cell、Track lane、HUD、collision、score 與 fairness。
- Failure_Retry_and_Progress.md：鎖定 failure reason、retry、after-retry visual delta 與 Best score。
- MVP_Boundary_and_Success.md：鎖定 Included Scope、Excluded Scope、QA success 與 iOS simulator recording evidence。

### 下游讀取規則
- Game Director 先讀 High_Concept、First_10_Seconds、Primary_Objects_and_Rules；UI/UX 先讀 Game_Screen_Outline；spec review 必須讀全部 proposal card。
- Development 不應只讀 Game_Proposal.md；任何 gameplay、UI、QA 或 build 決策都要追溯到對應 proposal card 的 source_paths。
- source_paths: docs/planning/proposal/High_Concept.md; docs/planning/proposal/Game_Screen_Outline.md; docs/planning/proposal/First_10_Seconds.md; docs/planning/proposal/Primary_Objects_and_Rules.md; docs/planning/proposal/Failure_Retry_and_Progress.md; docs/planning/proposal/MVP_Boundary_and_Success.md

## English

### Proposal Index
- This file is a proposal index, not the full design payload. Downstream agents read this index first, then open only the relevant context card to avoid bloated context.
- Proposal detail is split into six cards: high concept, screen outline, first 10 seconds, object rules, failure/retry, and MVP boundary.

### Context Cards
- High_Concept.md locks player promise, left/right drift, hazard, boost, combo, pulse, and core feeling.
- Game_Screen_Outline.md locks portrait layout, HUD, safe area, track, background motion, and iPhone SE readability.
- First_10_Seconds.md locks the post-Start timeline and prevents empty scene, black screen, or passive pulse loss.
- Primary_Objects_and_Rules.md locks Player vehicle, Hazard, Boost cell, Track lane, HUD, collision, score, and fairness.
- Failure_Retry_and_Progress.md locks failure reason, retry, after-retry visual delta, and Best score.
- MVP_Boundary_and_Success.md locks Included Scope, Excluded Scope, QA success, and iOS simulator recording evidence.

### Downstream Read Policy
- Game Director reads High_Concept, First_10_Seconds, and Primary_Objects_and_Rules first; UI/UX reads Game_Screen_Outline first; spec review must read every proposal card.
- Development must not rely on Game_Proposal.md alone; gameplay, UI, QA, and build decisions must trace back to the matching proposal-card source_paths.
- source_paths: docs/planning/proposal/High_Concept.md; docs/planning/proposal/Game_Screen_Outline.md; docs/planning/proposal/First_10_Seconds.md; docs/planning/proposal/Primary_Objects_and_Rules.md; docs/planning/proposal/Failure_Retry_and_Progress.md; docs/planning/proposal/MVP_Boundary_and_Success.md

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md, GOOD_BAD_EXAMPLES.md.
- Gameplay depth evidence: player objective, first 10 seconds, risk/reward, combo/boost, failure reason, HUD feedback, and QA evidence are bounded for downstream planning.
- Visual richness evidence: VISUAL_RICHNESS.md defines screen layers, track material, VFX/motion, typography/icon direction, readability, and target-device constraints.
- Blockers: fail if the document only uses unsupported adjectives without measurable implementation evidence without concrete player action, system response, feedback, failure, and QA proof.

## Product Experience Alignment

- Product experience cards read: product_experience/ROUTING.md, PRODUCT_EXPERIENCE_RUBRIC.md, FIRST_RUN_CLARITY.md, FEEDBACK_AND_GAME_FEEL.md, HUMAN_VISUAL_QA_GATES.md.
- First-run clarity evidence: objective, controlled object, danger, next action, success signal, failure reason, and retry recovery must be understandable from screen/video evidence.
- Feedback/game feel evidence: important input, score, collision, near miss, boost, failure, pause, and retry events must include visible/audio/haptic feedback expectations.
- Human visual QA: automated checks do not pass the product if screenshots/video remain unreadable, visually inert, confusing, or lack clear product value.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_PLANNER_ROLE.md, DESIGN_METHODS.md, VALIDATION_GATES.md.
- GAME_DEV_BLACK_BOOK_REFERENCE.md used: user-centric reverse deduction, MDA mapping, player agency, FTUE, sensory validation, MVP loop, and QA evidence are preserved.
- GDD_STRUCTURE_REFERENCE.md used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan are converted into bounded planning commitments.
- Implementation readiness: downstream agents must receive enough player action, input/state/rule/output, feedback, risk, reset, and acceptance detail to avoid inventing core gameplay during development.
