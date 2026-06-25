# UI UX Detail Spec

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md.
- Visual art reference used: visual communication, composition, asset language, motion art, and hierarchy are translated into implementation-ready fields.
- Gameplay depth score: spec review target 3+; evidence must include trigger, state, rule, HUD feedback, QA acceptance, and implementation-ready feature boundaries.
- Visual richness score: spec review target 3+; evidence must include asset list, VFX event table, typography/icon style, particle/VFX budget, reduced-motion fallback, and performance guardrail.
- Current-stage minimum: gameplay depth 3+ and visual richness 3+.
- Pass/fail: fail if the spec only says fun, polished, neon, challenging, or better visuals without concrete implementation fields.
- Blockers: return to planning when depth or richness is missing from planning sources.

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

- 主畫面需要 Start、Settings、Best Score；遊戲中 HUD 需要 current score、combo/boost 狀態與 pause。
- 所有主要觸控目標不得小於 44x44 pt，safe area 規則要求 HUD 必須避開 notch、Dynamic Island 與 home indicator。
- 失敗畫面需要 final score、best score、retry、back to menu，retry 必須是一個主要操作。
- Icon contract: Start 使用 lucide:Play，Settings 使用 lucide:Settings，Best Score 使用 lucide:Trophy，Pause 使用 lucide:Pause，Retry 使用 lucide:RotateCcw，Back 使用 lucide:Home，Speed 使用 lucide:Gauge，Boost 使用 lucide:Zap，Danger 使用 lucide:AlertTriangle。
- Icon size: menu/action icon 為 24x24 pt、HUD icon 為 20x20 pt、alert/failure icon 為 28x28 pt；所有 icon button touch target 仍為 44x44 pt，stroke 2 pt，outline style。
- Icon fallback: 若 lucide 不可用，使用等價 SF Symbols 或簡化線框圖示，且必須保留相同語意、尺寸、safe area、accessibility label 與 normal/pressed/disabled/alert 狀態色。
- Operation feel: Start Run、Drift、Boost、Crash、Retry 必須保留 latency target、camera response、HUD feedback 與 haptics cue；Prototype_Flow_Canvas.html 是操作節奏參考。
- Apple HIG Alignment: HIG cards read 包含 ROUTING.md、CORE_PRINCIPLES.md、GAME_UI_CHECKLIST.md、ACCESSIBILITY_LOCALIZATION.md、VALIDATION_GATES.md；platform assumptions 為 iPhone-first Unity game，safe area 避開 notch、Dynamic Island、home indicator；accessibility 需要 label、狀態、touch target 與 reduced motion fallback；intentional deviations 僅允許不破壞可讀性的高速霓虹動效。

## English

- The main menu needs Start, Settings, and Best Score; in-run HUD needs current score, combo or boost state, and pause.
- Primary touch targets must be at least 44x44 pt, and HUD must avoid notch, Dynamic Island, and home indicator areas.
- The failure screen needs final score, best score, retry, and back to menu, with retry as the primary action.
- Icon contract: Start uses lucide:Play, Settings uses lucide:Settings, Best Score uses lucide:Trophy, Pause uses lucide:Pause, Retry uses lucide:RotateCcw, Back uses lucide:Home, Speed uses lucide:Gauge, Boost uses lucide:Zap, and Danger uses lucide:AlertTriangle.
- Icon size: menu/action icons are 24x24 pt, HUD icons are 20x20 pt, alert/failure icons are 28x28 pt; every icon button still has a 44x44 pt touch target, 2 pt stroke, and outline style.
- Icon fallback: if lucide is unavailable, use equivalent SF Symbols or simplified line icons while preserving meaning, size, safe area behavior, accessibility label, and normal/pressed/disabled/alert color states.
- Operation feel: Start Run, Drift, Boost, Crash, and Retry must preserve latency target, camera response, HUD feedback, and haptics cue; Prototype_Flow_Canvas.html is the rhythm reference.
- Apple HIG Alignment: HIG cards read include ROUTING.md, CORE_PRINCIPLES.md, GAME_UI_CHECKLIST.md, ACCESSIBILITY_LOCALIZATION.md, and VALIDATION_GATES.md; platform assumptions are an iPhone-first Unity game with safe area avoidance for notch, Dynamic Island, and home indicator; accessibility requires labels, states, touch targets, and reduced-motion fallback; intentional deviations allow high-speed neon motion only when readability remains intact.
