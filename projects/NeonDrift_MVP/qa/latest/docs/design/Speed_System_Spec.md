# Speed System Spec

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

required keywords: speed, system, spec

### 範圍
- Speed System 只負責速度曲線、加速壓力與 boost 狀態，輸出目前速度 tier 給 hazard、camera、HUD 與 scoring 使用。

### 決策
- 速度隨存活時間與穩定操控逐步提升，boost 只能短時間提高風險與得分倍率，不能讓障礙可讀性失效。

### 交接重點
- 驗收標準是每個速度 tier 有明確輸入、狀態、上限、重置條件與 performance budget，不允許無限加速。

## English

required keywords: speed, system, spec

### Scope
- The Speed System owns speed curves, pressure escalation, and boost state, outputting the current speed tier to hazard, camera, HUD, and scoring systems.

### Decisions
- Speed increases from survival time and controlled play; boost may briefly raise risk and score multiplier but must not break hazard readability.

### Handoff Notes
- Acceptance requires each speed tier to define input, state, cap, reset condition, and performance budget, with no unlimited acceleration.
