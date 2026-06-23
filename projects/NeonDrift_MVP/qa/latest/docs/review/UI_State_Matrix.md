# UI State Matrix

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

- UI State Matrix 只定義 MainMenu、Running、Paused、Failure、RetryTransition 五個 UI state 與 allowed transitions。
- 每個 state 必須列出 visible elements、enabled controls、disabled controls、feedback events 與 exit trigger。
- Acceptance: GameSessionController 與 NeonDriftHud 可用本矩陣同步 UI 顯示，不需要推測狀態切換。

## English

- UI State Matrix defines only MainMenu, Running, Paused, Failure, and RetryTransition states plus allowed transitions.
- Each state must list visible elements, enabled controls, disabled controls, feedback events, and exit trigger.
- Acceptance: GameSessionController and NeonDriftHud can synchronize UI display from this matrix without guessing transitions.
