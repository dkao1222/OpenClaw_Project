# Game Design Document

Document contract: this file records only the current stage decision surface for the next planning owner. Do not copy full prior documents, and keep each subsection compact.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md, VISUAL_ART_REFERENCE.md; use GAMEPLAY_DEPTH.md and VISUAL_RICHNESS.md when this file affects gameplay or presentation.
- Visual art reference used: visual communication, composition, asset language, motion art, and hierarchy must be converted into concrete planning fields.
- Gameplay depth score: target 3 when this file owns game systems, GDD, mechanics, content, or production readiness; otherwise inherited from upstream planning.
- Gameplay depth evidence: short-session objective, player decision, risk/reward, combo, boost, wave/phase, hazard pattern, failure reason, HUD feedback, and QA acceptance must be explicit before development.
- Visual richness score: target 3 when this file owns visual direction, art/audio, feedback, GDD, or production readiness; otherwise inherited from upstream planning.
- Visual richness evidence: visual richness target, minimum polish bar, background layers, track materials, typography style, icon style, motion polish, particle/VFX budget, reduced motion fallback, and performance target must be explicit before development.
- Asset sourcing cards read: asset_sourcing/ROUTING.md, OPENGAMEART_USAGE.md, LICENSE_DECISION_MATRIX.md, ASSET_ATTRIBUTION_REGISTER.md when external art, sound, music, textures, fonts, icons, or OpenGameArt are referenced.
- External asset sourcing status: third-party assets require title, author, URL, exact license, attribution text, modification flag, store compatibility decision, implementation path, and QA evidence; prefer self-generated or CC0 assets for mobile ad apps.
- Current-stage minimum: planning final requires gameplay depth 3+ and visual richness 3+.
- Blockers: fail the stage if depth/richness is described only as fun, polished, neon, or challenging without concrete rules, assets, event feedback, and acceptance criteria.

## Product Experience Alignment

- Product experience cards read: product_experience/ROUTING.md, PRODUCT_EXPERIENCE_RUBRIC.md, FIRST_RUN_CLARITY.md, FEEDBACK_AND_GAME_FEEL.md, HUMAN_VISUAL_QA_GATES.md.
- First-run clarity target: planning must describe what the player controls, what is dangerous, what to do next, what success looks like, and why failure happens from the screen itself.
- Feedback/game feel target: every key input, score, near miss, combo, boost, hazard, failure, pause, and retry must define visual/audio/haptic response, timing, and reduced-motion fallback.
- Human visual QA target: QA must judge screenshots/video for readability, motion comprehension, state isolation, and product value, not only object existence or runtime probe fields.
- Blockers: fail if automated checks could pass while a human cannot understand the objective, controls, threat, reward, or retry state from visible evidence.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_DESIGN_LAYERS.md, DESIGN_METHODS.md, SYSTEM_SPEC_TEMPLATE.md, VALIDATION_GATES.md when this file affects game systems.
- Game Dev Black Book reference used: user-centric reverse deduction and MDA/feeling-to-system mapping must be visible when this file affects product promise, gameplay, FTUE, or QA evidence.
- GDD structure reference used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan must be covered before Spec Review.
- Game mechanics reference used: core mechanics, game loop, systems/tuning, and level design must be explicit and testable.
- Game terminology reference used: important terms must include category, player-facing meaning, system-facing meaning, owner, and acceptance.
- System purpose: every system must state player value, product value, and non-goals before spec review.
- 5W1H summary: What, Why, Who, Where, When, and How must be explicit for gameplay systems, content, activities, rewards, and GDD rules.
- Layer coverage: strategy, scope, structure, interaction, and presentation must be covered before development.
- Implementation handoff readiness: state, input, output, rule, dependency, feedback, edge case, config, and QA acceptance must be present.
- Risks or blockers: fail the stage if a system requires engineering to invent missing behavior.

## 繁體中文

required keywords: game, design, document

### 範圍
- MVP 範圍是 iPhone-first 單人 NeonDrift 短局遊戲：主選單、開始、漂移操控、速度風險、分數、碰撞失敗、重試與基本設定。

### 決策
- 核心循環是 Start Run -> 左右操控漂移 -> 避開障礙與維持賽道線 -> 以存活時間、近距離閃避與穩定控制累積分數 -> failure -> Retry；Compatibility Matrix 必須涵蓋 iOS 15+、iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro、Android 10+ 代表機與 WebGL desktop browser。

### 交接重點
- 玩法內容深度必須在 planning 鎖定：Moment-to-moment gameplay、0-10 second playability timeline、Enemy Pattern Spec、Player Skill Reward Spec、Human Playtest Scenarios、Content Objective System、Wave Objective、Boost Cell、Combo Chain、Hazard Pattern、wave objective、boost cell、combo chain、hazard pattern、短局任務與失敗原因提示都要有規劃來源；視覺必須鎖定 neon arcade presentation、screen composition、safe area、touch target、visual readability、audio/haptics、aspect ratio、performance budget，development 不可自行臨時新增核心玩法或補設計債。

## English

required keywords: game, design, document

### Scope
- The MVP scope is an iPhone-first single-player NeonDrift short-session game: main menu, start, drift control, speed risk, score, collision failure, retry, and basic settings.

### Decisions
- The core loop is Start Run -> steer drifting -> avoid hazards and stay readable on the racing line -> score through survival time, near misses, and control consistency -> failure -> Retry; the Compatibility Matrix must cover iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, representative Android 10+ devices, and WebGL desktop browsers.

### Handoff Notes
- Gameplay content depth must be locked during planning: Moment-to-moment gameplay, 0-10 second playability timeline, Enemy Pattern Spec, Player Skill Reward Spec, Human Playtest Scenarios, Content Objective System, Wave Objective, Boost Cell, Combo Chain, Hazard Pattern, wave objective, boost cell, combo chain, hazard pattern, short-session missions, and failure reason hints need planning sources; visual and implementation guardrails must lock neon arcade presentation, screen composition, safe area, touch target, visual readability, audio/haptics, aspect ratio, and performance budget, so development does not invent core gameplay or repay design debt ad hoc.
