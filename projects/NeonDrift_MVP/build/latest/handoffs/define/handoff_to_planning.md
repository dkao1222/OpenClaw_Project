# Handoff: define to planning

```yaml
project_name: NeonDrift_MVP
define_page_id: 38db9e33-8429-8178-8df4-c6c88acfc59c
define_run_id: notion-NeonDrift_MVP-define-20260628123232
chain_id: raw:NeonDrift_MVP:20260628123217
output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
handoff_type: define_to_planning
ready_for_planning: true
planning_stage_range: 0-12
source_documents:
  - docs/define/Defined_Request.md
  - docs/define/Idea_Expansion_Governance.md
  - docs/define/Project_Input_Schema.md
  - docs/define/Pipeline_Gates.md
  - docs/define/Missing_Fields_Report.md
```

## Product Experience Contract

Game Design Foundation Contract:
- Reference cards: game_system_design/GAME_DEV_BLACK_BOOK_REFERENCE.md, game_system_design/GDD_STRUCTURE_REFERENCE.md, game_system_design/GAME_MECHANICS_REFERENCE.md, game_system_design/GAME_TERMINOLOGY_REFERENCE.md, and game_quality/VISUAL_ART_REFERENCE.md must be used as bounded knowledge. Do not paste full external articles into agent context.
- GDD Structure: Planning must cover Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan before Spec Review.
- User-Centric Reverse Deduction: Define and Planning must translate user profile -> psychological need -> mechanic/system -> production/QA evidence before development.
- MDA / Feeling-to-System Mapping: every core feature must map mechanic, dynamic, and aesthetic; QA must verify runtime evidence supports the intended feeling, not only object existence.
- Core Mechanics（核心機制）: Define and Planning must name the repeatable player actions that form the gameplay foundation, such as drift, jump, shoot, build, dodge, aim, collect, or upgrade. A game cannot proceed with only passive scoring or decorative motion.
- Game Loop（遊戲循環）: Planning must express the repeatable behavior pattern as a loop, for example explore -> collect -> build -> upgrade, start -> drift -> avoid -> score -> fail -> retry, or equivalent. Each loop step needs player intent, system response, feedback, and progression meaning.
- Systems and Tuning（系統與數值）: Planning/Spec Review must define the core systems and numbers that make the game challenging and fair, including economy/reward rules where relevant, damage or failure calculation, growth/progression curve, probability/spawn balance, difficulty ramp, and fairness/readability limits.
- Level Design（關卡設計）: Planning must define spatial layout and pacing rules that guide the player and create memorable play moments, including lanes/space, spawn rhythm, encounter pacing, tutorial/readability beats, safe windows, pressure peaks, and recovery moments.
- Development and QA must reject outputs where these four foundations remain generic, missing, or not testable.
- Moment-to-Moment Gameplay Contract: Planning must define the first 10 seconds of play as timestamped beats: player sees objective, player performs input, system creates pressure, enemy/hazard advances, feedback confirms action, reward or failure teaches the next attempt.
- Encounter / Enemy Pattern Contract: Planning must define at least three concrete enemy or hazard patterns with spawn condition, movement/approach behavior, warning/readability cue, counterplay, reward/penalty, and QA reproduction step. A static or non-approaching threat fails.
- Player Skill and Reward Contract: Planning must define how player skill changes outcome, including near miss, combo, boost/reward, score formula, risk/reward tradeoff, reset/break condition, HUD/VFX/SFX feedback, and mastery signal.
- Human Playtest Contract: QA must verify from simulator video that a human can tell what the goal is, what is dangerous, what changed after input, why failure happened, and why retry is meaningful.

Human Playability Contract:
- The player must understand what to do within 3 seconds of the first playable screen.
- The first run must show visible player motion, visible hazard motion, and at least one player input that changes risk/outcome.
- The game may not be delivered as static rectangles, invisible controls, or a passive score timer.
- Retry must restart directly into a fresh playable run within 0.3 seconds unless the defined product explicitly says otherwise.
- Retry must create a human-visible state transition: failure overlay removed, score/timer/run state reset, player or track motion resumes, and the after-retry screenshot/video must differ clearly from the game-over screenshot.
- Failure must explain the cause in human-readable language and preserve a clear retry action.

Visual Richness Contract:
- Planning must define a minimum polish bar before development: background layers, track materials, player silhouette, hazard shapes, reward/boost visuals, HUD frame, typography, icon style, motion polish, and VFX budget.
- Visual richness must improve speed, risk, reward, and retry motivation without hiding the player, hazards, HUD, or controls.
- Debug-looking placeholder blocks, single-color empty playfields, overlapping state layers, or unreadable labels fail the contract.

Interaction and State Contract:
- Main Menu, Running, Paused, Failure, RetryTransition, and Settings must have mutually exclusive visible UI rules.
- Menu UI cannot be hidden in the menu screenshot; gameplay controls cannot remain active over Failure unless intentionally listed as disabled background context.
- Left/right input, pause, settings, sound toggle, and retry must each produce visible feedback.
- RetryTransition must have observable feedback such as panel fade, countdown, track flash, player respawn pulse, or refreshed hazard layout; a probe boolean alone is insufficient evidence.

Audio Feedback Contract:
- Sound On must produce verifiable audio or runtime evidence for start, drift/input, boost/reward, collision/failure, and retry/settings feedback.
- QA cannot pass audio by checking the existence of a Sound On label only.

Evidence Contract:
- Build/QA must provide simulator screenshots and playthrough video that prove menu readability, start action, gameplay motion, input effect, failure reason, retry restart, after-retry visual delta, and sound feedback evidence.

## Idea Expansion Governance

Define Idea Expansion Governance:
- Define may expand a raw idea only as labeled interpretation, assumption, candidate, or recommended-not-confirmed direction.
- Define must not promote invented gameplay, genre, story, platform, monetization, visual direction, success metric, or target audience into Confirmed Requirements unless the Raw Idea explicitly states it.
- Every Expansion Candidate must include: source cue from Raw Idea, proposed product/game direction, why it fits, gameplay impact, visual/experience impact, risk, and decision status.
- Recommended Direction is allowed, but it must be labeled Recommended, not confirmed.
- Planning may use candidates for comparison and synthesis, but must keep the candidate provenance visible in planning documents and handoffs.
- If Raw Idea is too thin, Define should still provide candidate directions, but Planning must mark the selected direction as assumption-backed instead of confirmed.

## Candidate Expansion Summary

### Confirmed Requirements
- project_name: NeonDrift_MVP
- raw_idea: Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel. The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention. The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score. The core gameplay is left/right drift control with visible vehicle movement, track motion, hazard approach, boost pickup, pulse drain, failure reason, pause, and retry. The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks. Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts. Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame. Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity Editor is available. QA must include simulator screenshots, playthrough video, button/touch layout checks, and every core gameplay function check.
- product_vision: 由 Raw Idea 正規化：Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel. The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention. The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score. The core gameplay is left/right drift control with visible vehicle movement, track motion, hazard approach, boost pickup, pulse drain, failure reason, pause, and retry. The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks. Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts. Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame. Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity Editor is available. QA must include simulator screenshots, playthrough video, button/touch layout checks, and every core gameplay function check. 遊戲概念：Neon arcade drift runner: the player pilots a glowing hover car in a moving light tunnel, making quick left/right drift decisions under pressure. 玩家目標：Survive the run, avoid hazard shards, collect boost cells, chain near misses/combo score, and beat the best score with fast retry. 必須包含：Start menu, Settings/Sound, best score, left/right touch controls, moving player vehicle, track/background motion, hazards, boost
- target_audience_field: 由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。
- core_value_field: 由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。 核心玩法：Tap/hold left or right to drift between lanes while the track scrolls. Hazards damage/end the run, boosts restore pulse and score, and retry must restart a fresh moving run. 核心物件：Player hover car, neon track/lane rails, hazard shards, boost cells, score/combo/pulse HUD, pause, failure overlay with reason, retry button. 視覺方向：High-contrast neon arcade style with moving background layers, visible vehicle silhouette, cyan/magenta hazard-reward language, glow trails, readable HUD, and safe-area aware controls. 成功條件：QA must provide screenshots/video proving Start, moving gameplay, left/right control response, hazard, boost, score/pulse change, failure reason, retry reset, visual richness, and non-placeholder style frames. QA 要求：QA must include simulator screenshots, playthrough video, touch/button checks, every gameplay function check, human visual readability, product experience, style-frame evidence, retry recovery, and build artifacts.
- platform_target_field: Unity iOS first; Android/WebGL only as future scope unless explicitly requested.
- monetization_direction_field: Rewarded ads may be considered only after failure/retry or future revive/bonus flows; ads must not interrupt the first run or core tutorial experience.
- compatibility_target_field: iOS-first Unity 6000.0.77f1, local iOS simulator build, safe-area aware controls, readable on common iPhone portrait screens, performance suitable for mid-range iOS devices.
- output_expectation_field: Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input. References: Use OpenClaw knowledge bases for Apple HIG, product experience, game quality, game system design, visual richness, and OpenGameArt-compatible asset direction. QA Requirement: QA must include simulator screenshots, playthrough video, touch/button checks, every gameplay function check, human visual readability, product experience, style-frame evidence, retry recovery, and build artifacts.

### Expansion Candidates
- Candidate 1: Skill Drift Survival | Player repeatedly drifts left/right through a readable lane/track space, avoids moving hazards, and builds score through near-miss skill. | status=Candidate, not confirmed
- Candidate 2: Rhythm Pressure Run | Player acts on timed pulses/windows; correct timing grants combo/boost, late or wrong action increases danger. | status=Candidate, not confirmed
- Candidate 3: Progressive Mastery Challenge | The MVP adds staged hazard patterns, combo rules, simple unlock/progression, and post-run feedback so each retry teaches a new skill. | status=Candidate, not confirmed

### Recommended Direction

- Recommended, not confirmed: combine Skill Drift Survival with Progressive Mastery Challenge for MVP; use Rhythm/Timed Pressure only if Planning can keep controls readable and QA-testable.
- status=Recommended, not confirmed

### Open Questions
- Which Expansion Candidate should be treated as the MVP direction, or should Planning compare all candidates first?
- What is the strongest intended player feeling: speed, mastery, tension, relaxation, strategy, collection, or spectacle?
- Which visual references are approved, and which are only inspirational?
- What must be excluded from MVP scope even if it would increase depth or polish?
- What is the minimum acceptable device/OS compatibility target for release, not only simulator testing?

## Next Step

Create a Planning row from this canonical defined request. Do not read unbounded raw request text.
