# Implementation Readiness Checklist

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md.
- Visual art reference used: visual communication, composition, asset language, motion art, and hierarchy are translated into implementation-ready fields.
- Gameplay depth score: spec review target 3+; evidence must include trigger, state, rule, HUD feedback, QA acceptance, and implementation-ready feature boundaries.
- Visual richness score: spec review target 3+; evidence must include asset list, VFX event table, typography/icon style, particle/VFX budget, reduced-motion fallback, and performance guardrail.
- Asset sourcing cards read: asset_sourcing/ROUTING.md, OPENGAMEART_USAGE.md, LICENSE_DECISION_MATRIX.md, ASSET_ATTRIBUTION_REGISTER.md, and AUDIO_ASSET_CHECKLIST.md when external art/audio sources are referenced.
- License readiness: third-party assets require exact license, attribution, store decision, implementation path, and QA evidence; GPL/LGPL/CC-BY-SA/unclear licenses are blocked by default for mobile store builds.
- Current-stage minimum: gameplay depth 3+ and visual richness 3+.
- Pass/fail: fail if the spec only says fun, polished, neon, challenging, or better visuals without concrete implementation fields.
- Blockers: return to planning when depth or richness is missing from planning sources.

## Product Experience Alignment

- Product experience cards read: product_experience/ROUTING.md, PRODUCT_EXPERIENCE_RUBRIC.md, FIRST_RUN_CLARITY.md, FEEDBACK_AND_GAME_FEEL.md, HUMAN_VISUAL_QA_GATES.md.
- First-run clarity target: a human viewer must understand the objective, controllable object, danger, next action, success signal, and failure reason from the first screen and first 10 seconds.
- Feedback/game feel target: every important input, score, collision, near miss, boost, failure, pause, and retry event must specify visual/audio/haptic response and timing.
- Human visual QA target: screenshots and video must be readable without relying on JSON probes or hidden flags.
- Pass/fail: fail if automated UI checks pass but the screen is unreadable, visually inert, confusing, or lacks clear product value.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_DESIGN_LAYERS.md, SYSTEM_SPEC_TEMPLATE.md, VALIDATION_GATES.md.
- Game Dev Black Book reference used: user-centric reverse deduction, MDA/feeling-to-system mapping, player agency, FTUE, sensory validation, MVP loop, and QA evidence are translated into spec acceptance.
- GDD structure reference used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan are converted into implementation-ready specs.
- Game mechanics reference used: player action, system response, state change, feedback, constraints, and success/failure meaning are explicit.
- Game terminology reference used: important genre, mechanic, level/content, system, UI/feedback, reward, and player terms have player meaning, system meaning, and acceptance.
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
- Block if missing: Game Design Foundation Contract、Core Mechanics、Game Loop、Systems and Tuning、Level Design、Human Playability Contract、Interaction and State Contract、Audio Feedback Contract、Evidence Contract 任一未轉成 implementation/QA acceptance，也不可進入 development。

## English

- Ready: platform direction, MVP scope, core loop, screen list, HUD, failure/retry flow, visual/audio feedback, and visual richness target are defined.
- Ready: the development backlog can split into project shell, gameplay, UI, feedback, QA, and final package.
- Note: development must use handoff_to_game_development.md as the only entry point and wait for user confirmation.
- Block if missing: icon contract, operation feel, canvas artifact, game systems contract, gameplay content layer, visual richness target, particle/VFX budget, minimum polish bar, or GDD acceptance criteria must prevent development.
- Block if missing: if the Game Design Foundation Contract, Core Mechanics, Game Loop, Systems and Tuning, Level Design, Human Playability Contract, Interaction and State Contract, Audio Feedback Contract, or Evidence Contract is not converted into implementation/QA acceptance, development must not start.
