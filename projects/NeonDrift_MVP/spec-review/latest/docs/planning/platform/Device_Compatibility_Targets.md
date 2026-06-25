# Platform Card: Device Compatibility Targets

## 繁體中文

### 裝置相容性
- Primary：iOS 15+，iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro；必須覆蓋小螢幕、notch、Dynamic Island、不同 safe area。
- Secondary：Android 10+ 代表機、WebGL desktop browser；除非本次需求明確要求，多平台只保留設計與 build path，不阻塞 iOS-first MVP。

### 效能目標
- 目標 60 FPS；低階機可接受短暫降幀但不可卡死、不可輸入延遲超過玩家可感知穩定範圍。
- 視覺華麗度需要 particle/VFX budget；背景、速度線、glow、trail 不可遮蔽 hazard 或 HUD。

### 不合格條件
- iPhone SE 上按鍵過小、HUD 被 safe area 擋住、文字不可讀、notch/Dynamic Island 覆蓋 score/pulse、frame pacing 讓 drift 難以控制，都算不合格。

## English

### Device Compatibility
- Primary: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro; must cover small screen, notch, Dynamic Island, and different safe areas.
- Secondary: Android 10+ representative devices and WebGL desktop browser; unless requested, multiplatform remains design/build path and does not block iOS-first MVP.

### Performance Target
- Target 60 FPS; low-end devices may briefly dip but cannot freeze or create unstable perceptible input delay.
- Visual richness needs particle/VFX budget; background, speed lines, glow, and trail cannot hide hazards or HUD.

### Failure Conditions
- Fails if iPhone SE buttons are too small, HUD is blocked by safe area, text is unreadable, notch/Dynamic Island covers score/pulse, or frame pacing makes drift hard to control.

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
