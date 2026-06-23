# Accessibility and Safe Area Spec

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

- Accessibility and Safe Area Spec 只定義 safe area、touch target、reduced motion、contrast、label 與 feedback 降級規則。
- iPhone-first layout 必須避開 notch、Dynamic Island、home indicator；主要操作不得小於 44x44 pt。
- Acceptance: reduced motion 關閉 screen shake 與高頻閃爍，所有 icon-only control 都有 accessibility label。

## English

- Accessibility and Safe Area Spec defines only safe areas, touch targets, reduced motion, contrast, labels, and feedback fallback rules.
- The iPhone-first layout must avoid notch, Dynamic Island, and home indicator; primary actions cannot be smaller than 44x44 pt.
- Acceptance: reduced motion disables screen shake and high-frequency flashing, and every icon-only control has an accessibility label.
