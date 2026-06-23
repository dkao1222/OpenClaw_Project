# Feedback Event Detail Spec

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

- Feedback Event Detail Spec 只定義 start、drift、boost、near miss、score tick、collision、retry 的 HUD/SFX/haptics/camera event。
- haptics 僅用於 collision 與高價值 near miss/boost，不可在每次普通得分時震動。
- Acceptance: feedback event 不遮擋車體、障礙、HUD，也不破壞 reduced motion 設定。

## English

- Feedback Event Detail Spec defines only HUD/SFX/haptics/camera events for start, drift, boost, near miss, score tick, collision, and retry.
- Haptics are reserved for collision and high-value near miss/boost, not every ordinary score tick.
- Acceptance: feedback events do not obscure the vehicle, hazards, or HUD, and do not break reduced-motion settings.
