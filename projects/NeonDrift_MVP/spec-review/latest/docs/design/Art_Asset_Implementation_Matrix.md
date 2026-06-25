# Art Asset Implementation Matrix

Document contract: this file records only the current stage decision surface for the next planning owner. Do not copy full prior documents, and keep each subsection compact.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md, VISUAL_ART_REFERENCE.md; use GAMEPLAY_DEPTH.md and VISUAL_RICHNESS.md when this file affects gameplay or presentation.
- Visual art reference used: visual communication, composition, asset language, motion art, and hierarchy must be converted into concrete planning fields.
- Gameplay depth score: target 3 when this file owns game systems, GDD, mechanics, content, or production readiness; otherwise inherited from upstream planning.
- Gameplay depth evidence: short-session objective, player decision, risk/reward, combo, boost, wave/phase, hazard pattern, failure reason, HUD feedback, and QA acceptance must be explicit before development.
- Visual richness score: target 3 when this file owns visual direction, art/audio, feedback, GDD, or production readiness; otherwise inherited from upstream planning.
- Visual richness evidence: visual richness target, minimum polish bar, background layers, track materials, typography style, icon style, motion polish, particle/VFX budget, reduced motion fallback, and performance target must be explicit before development.
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

required keywords: art, asset, implementation, matrix

### 範圍
- Art Asset Implementation Matrix 必須把每個美術資產連到 Unity 目標：asset path、Unity object/component、screen state、trigger event、variation rule、fallback、QA evidence。

### 決策
- 至少要包含 background layers、track materials、player vehicle、hazard shard、boost cell、combo pulse、near-miss streak、failure flash、retry surge、HUD frame、button/icon style、score typography。

### 交接重點
- 每個資產都要有 variation 或狀態差異；如果資產只存在於 PNG/manifest 但沒有進 Unity 畫面，development gate 必須失敗。

## English

required keywords: art, asset, implementation, matrix

### Scope
- Art Asset Implementation Matrix maps every art asset to implementation: asset path, Unity object/component, screen state, trigger event, variation rule, fallback, and QA evidence.

### Decisions
- It must include background layers, track materials, player vehicle, hazard shard, boost cell, combo pulse, near-miss streak, failure flash, retry surge, HUD frame, button/icon style, and score typography.

### Handoff Notes
- Every asset needs variation or state difference; if an asset exists only as PNG/manifest and is not used in the Unity screen, the development gate fails.
