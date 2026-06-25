# Core Gameplay Loop

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

required keywords: core, gameplay, loop

### 範圍
- 核心循環由進入賽道、操控漂移、累積分數、承擔風險、失敗後立即重試構成。

### 決策
- 每局至少包含一個可見短局目標：建立 combo、收集 boost cell、撐過 wave、避開指定 hazard pattern；目標必須映射到 HUD 與 failure feedback。

### 交接重點
- 每一輪都要讓玩家在十秒內理解目標，並在三十秒內看到分數或技巧進步。

## English

required keywords: core, gameplay, loop

### Scope
- The core loop starts with a run, asks the player to steer through risk, converts survival into score, and returns quickly to retry after failure.

### Decisions
- Each run needs at least one visible short-session objective: build combo, collect boost cell, survive a wave, or avoid a specific hazard pattern; the objective must map to HUD and failure feedback.

### Handoff Notes
- Each session should expose the objective within seconds and show measurable mastery within a short run.
