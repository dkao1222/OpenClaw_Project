# Implementation Readiness Checklist

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

- Ready: platform direction、MVP scope、core loop、screen list、HUD、failure/retry flow、visual/audio feedback、visual richness target 都已定義。
- Ready: development backlog 可拆成 project shell、gameplay、UI、feedback、QA 與 final package。
- 注意: development 仍需使用 handoff_to_game_development.md 作為唯一入口，並等待使用者確認。
- Block if missing: icon contract、operation feel、canvas artifact、game systems contract、gameplay content layer、visual richness target、particle/VFX budget、minimum polish bar、GDD acceptance criteria 任一缺失都不可進入 development。

## English

- Ready: platform direction, MVP scope, core loop, screen list, HUD, failure/retry flow, visual/audio feedback, and visual richness target are defined.
- Ready: the development backlog can split into project shell, gameplay, UI, feedback, QA, and final package.
- Note: development must use handoff_to_game_development.md as the only entry point and wait for user confirmation.
- Block if missing: icon contract, operation feel, canvas artifact, game systems contract, gameplay content layer, visual richness target, particle/VFX budget, minimum polish bar, or GDD acceptance criteria must prevent development.
