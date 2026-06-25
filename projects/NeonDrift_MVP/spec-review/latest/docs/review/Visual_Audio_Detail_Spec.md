# Visual Audio Detail Spec

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

- Visual Audio Detail Spec 只定義可開發的 art direction、visual richness target、audio identity、VFX/audio event pairing 與可讀性限制。
- 視覺華麗度目標是 neon arcade presentation，最低華麗度門檻包含 background layers、track materials、cyan/magenta lane identity、vehicle silhouette、hazard shapes、boost cell 高價值視覺、HUD frame、button/icon style、score typography 與 screen composition。
- particle/VFX budget 必須列出 start sting、drift trail、boost cell pickup、combo pulse、near-miss streak、score tick、collision hit、failure flash、retry transition 的粒子數、持續時間、透明度上限、screen shake 強度與 reduced motion fallback。
- Bloom 和 screen shake 必須保守使用，任何 VFX 不得遮住車體、障礙、HUD 或節奏提示；危險色不可和獎勵色混淆。
- 音效需要 start、drift、boost pickup、combo、near miss、score tick、collision、retry；haptics 僅用於碰撞與高價值回饋。
- Acceptance: iPhone SE 2/3 與 iPhone 15 上仍需滿足 readability gate，若缺少 visual richness target、particle/VFX budget、typography style、icon style、motion polish 或 minimum polish bar，不可進入 development。

## English

- Visual Audio Detail Spec defines buildable art direction, visual richness target, audio identity, VFX/audio event pairing, and readability limits.
- The visual richness target is neon arcade presentation, with a minimum polish bar covering background layers, track materials, cyan/magenta lane identity, vehicle silhouette, hazard shapes, high-value boost cell visuals, HUD frame, button/icon style, score typography, and screen composition.
- The particle/VFX budget must list particle count, duration, opacity cap, screen shake intensity, and reduced-motion fallback for start sting, drift trail, boost cell pickup, combo pulse, near-miss streak, score tick, collision hit, failure flash, and retry transition.
- Bloom and screen shake must be conservative, and VFX must not obscure the vehicle, hazards, HUD, or timing cues; danger color must not conflict with reward color.
- Audio needs start, drift, boost pickup, combo, near miss, score tick, collision, and retry cues; haptics are reserved for collision and high-value feedback.
- Acceptance: iPhone SE 2/3 and iPhone 15 must still satisfy the readability gate; missing visual richness target, particle/VFX budget, typography style, icon style, motion polish, or minimum polish bar blocks development.
