# Proposal Card: MVP Boundary and Success

## 繁體中文

### MVP 邊界與成功條件
- MVP Boundary 是驗證 iOS simulator 上可玩、可看、可測、可重試的 neon drift loop，不是完整商業遊戲。
### 包含範圍
- Included Scope：Start、Settings、Pause、Retry、Best score、left/right control、hazard spawn、boost pickup、score/combo/pulse、game-over reason、local iOS simulator build、QA video/recording evidence。
### 排除範圍
- Excluded Scope：multiplayer、leaderboard、cloud save、IAP、shop、gacha、large level editor、production ad implementation；ads 只保留 privacy/AdMob readiness 與 placement design。

## English

### MVP Boundary and Success Criteria
- MVP Boundary validates a playable, visible, testable, retryable neon drift loop on iOS simulator, not a full commercial game.
### Included Scope
- Included Scope: Start, Settings, Pause, Retry, Best score, left/right control, hazard spawn, boost pickup, score/combo/pulse, game-over reason, local iOS simulator build, and QA video/recording evidence.
### Excluded Scope
- Excluded Scope: multiplayer, leaderboard, cloud save, IAP, shop, gacha, large level editor, and production ad implementation; ads keep only privacy/AdMob readiness and placement design.

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
