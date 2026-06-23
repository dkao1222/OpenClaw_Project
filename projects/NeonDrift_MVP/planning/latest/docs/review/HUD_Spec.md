# HUD Spec

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md.
- Gameplay depth score: spec review target 3+; evidence must include trigger, state, rule, HUD feedback, QA acceptance, and implementation-ready feature boundaries.
- Visual richness score: spec review target 3+; evidence must include asset list, VFX event table, typography/icon style, particle/VFX budget, reduced-motion fallback, and performance guardrail.
- Current-stage minimum: gameplay depth 3+ and visual richness 3+.
- Pass/fail: fail if the spec only says fun, polished, neon, challenging, or better visuals without concrete implementation fields.
- Blockers: return to planning when depth or richness is missing from planning sources.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, SYSTEM_DESIGN_LAYERS.md, SYSTEM_SPEC_TEMPLATE.md, VALIDATION_GATES.md.
- System purpose: spec must preserve player value, product value, and non-goals from planning.
- 5W1H summary: spec review target requires What, Why, Who, Where, When, and How for every implementation-facing system.
- Layer coverage: strategy, scope, structure, interaction, and presentation must be represented in implementable detail.
- Implementation handoff readiness: state transitions, formulas, caps, reset conditions, dependencies, config fields, feedback, and QA acceptance must be clear.
- Risks or blockers: return to planning when engineering would need to invent missing system behavior.

## 繁體中文

- HUD Spec 只定義 run 期間可見的 current score、wave objective、combo/boost、speed/danger、pause 與 failure cue，不承擔 menu layout。
- HUD 必須遵守 safe area，避開 notch、Dynamic Island、home indicator，資訊優先順序為 survival/score > active objective > danger > boost/combo > pause。
- Acceptance: iPhone SE 2/3 與 iPhone 15 上所有 HUD 元件不遮擋車體、障礙、觸控區或視覺警示。

## English

- HUD Spec defines only visible in-run current score, wave objective, combo/boost, speed/danger, pause, and failure cues; it does not own menu layout.
- HUD must follow safe area rules and avoid notch, Dynamic Island, and home indicator, with priority survival/score > active objective > danger > boost/combo > pause.
- Acceptance: on iPhone SE 2/3 and iPhone 15, HUD elements do not obscure the vehicle, hazards, touch zones, or warning cues.
