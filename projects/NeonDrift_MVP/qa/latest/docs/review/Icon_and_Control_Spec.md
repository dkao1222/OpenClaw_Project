# Icon and Control Spec

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md.
- Visual art reference used: visual communication, composition, asset language, motion art, and hierarchy are translated into implementation-ready fields.
- Gameplay depth score: spec review target 3+; evidence must include trigger, state, rule, HUD feedback, QA acceptance, and implementation-ready feature boundaries.
- Visual richness score: spec review target 3+; evidence must include asset list, VFX event table, typography/icon style, particle/VFX budget, reduced-motion fallback, and performance guardrail.
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

- Icon and Control Spec 只定義 icon token、尺寸、touch target、控制區與 accessibility label。
- Icon contract: Start lucide:Play、Settings lucide:Settings、Best Score lucide:Trophy、Pause lucide:Pause、Retry lucide:RotateCcw、Back lucide:Home、Speed lucide:Gauge、Boost lucide:Zap、Danger lucide:AlertTriangle。
- Icon size: menu/action 24x24 pt、HUD 20x20 pt、alert/failure 28x28 pt；所有 icon button touch target 為 44x44 pt，stroke 2 pt，並具 normal/pressed/disabled/alert 狀態。
- Acceptance: 若 lucide 不可用，可用等價 SF Symbols，但語意、尺寸、accessibility label 與狀態色不可改變。

## English

- Icon and Control Spec defines only icon tokens, sizes, touch targets, control zones, and accessibility labels.
- Icon contract: Start lucide:Play, Settings lucide:Settings, Best Score lucide:Trophy, Pause lucide:Pause, Retry lucide:RotateCcw, Back lucide:Home, Speed lucide:Gauge, Boost lucide:Zap, Danger lucide:AlertTriangle.
- Icon size: menu/action 24x24 pt, HUD 20x20 pt, alert/failure 28x28 pt; all icon buttons use 44x44 pt touch targets, 2 pt stroke, and normal/pressed/disabled/alert states.
- Acceptance: if lucide is unavailable, equivalent SF Symbols may be used, but meaning, size, accessibility label, and state color cannot change.
