# Proposal Card: MVP Boundary and Success

## 繁體中文

### MVP 邊界與成功條件
- MVP Boundary 是驗證 iOS simulator 上可玩、可看、可測、可重試的 neon drift loop，不是完整商業遊戲。成功不是只有 build success，而是 QA recording 能證明主要功能與遊戲可理解。
- 最小成功條件：Start 可進入 gameplay、left/right 會影響 vehicle、hazard/boost 可見且有規則、score/combo/pulse 有因果變化、failure reason 正確、Retry 可重開一輪。

### 包含範圍
- Product scope：Start、Settings、Pause、Retry、Best score、left/right control、hazard spawn、boost pickup、score/combo/pulse、game-over reason。
- Technical scope：Unity 6000.0.77f1、iOS simulator build、safe area、iPhone SE readable HUD、runtime probe、screenshots、simulator_playthrough.mp4。
- QA scope：每個主要功能都要有 test case；QA 影片要證明不是黑屏、不是空場景、不是被 overlay 擋住、不是無操作自動失敗。

### 排除範圍
- Excluded Scope：multiplayer、leaderboard、cloud save、IAP、shop、gacha、large level editor、production ad implementation、正式 App Store submission package。
- Ads 只保留 privacy/AdMob readiness 和 placement design，不在 MVP 內實作正式收益流程；若後續加入廣告，不能放在 first-run learning 前阻斷 Start/play/retry。

## English

### MVP Boundary and Success Criteria
- The MVP validates a playable, visible, testable, retryable neon drift loop on iOS simulator. Success requires QA recording evidence, not only build success.

### Included Scope
- Included scope covers Start, Settings, Pause, Retry, Best score, left/right control, hazard spawn, boost pickup, score/combo/pulse, game-over reason, Unity 6000.0.77f1 iOS simulator build, safe area, runtime probe, screenshots, and playthrough video.

### Excluded Scope
- Excluded scope covers multiplayer, leaderboard, cloud save, IAP, shop, gacha, large editor, production ads, and final store submission package.

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
