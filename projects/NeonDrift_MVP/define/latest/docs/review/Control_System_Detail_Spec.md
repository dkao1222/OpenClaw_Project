# Control System Detail Spec

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

- Control System Detail Spec 只定義 touch input、drift intent、steering output、input smoothing 與失敗前控制回饋。
- 輸入不得依賴不可見按鈕；left/right zones 需要在 onboarding 或首次 run 以視覺提示說明。
- Acceptance: 在 60fps 目標下，玩家操作與車體反應延遲需維持在可感知穩定範圍，且 readback QA 可重現。

## English

- Control System Detail Spec defines only touch input, drift intent, steering output, input smoothing, and pre-failure control feedback.
- Input cannot depend on invisible buttons; left/right zones need visual teaching in onboarding or the first run.
- Acceptance: at a 60fps target, player input and vehicle response latency remain predictably stable and reproducible by QA.
