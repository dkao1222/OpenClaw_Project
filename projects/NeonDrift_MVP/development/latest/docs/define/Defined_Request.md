# Defined Request

## Canonical Fields

- project_name: NeonDrift_MVP
- define_page_id: 38cb9e33-8429-81d6-889e-eec012a72a49
- define_run_id: notion-NeonDrift_MVP-define-20260627151218
- chain_id: raw:NeonDrift_MVP:20260627151214
- agent_model_policy: per-agent-config
- thinking: off

## Raw Idea（原始想法）

Create an iOS-first Unity 6000.0.77f1 arcade game MVP named NeonDrift_MVP. The player is a rookie courier piloting a cyan hover ship through a collapsing neon data highway inside a cyber-city. The center playfield must read as a dangerous moving lane/track, not an abstract rectangle. The player must immediately understand: cyan ship = me, neon track = survival lane, pink shards = crash threat, gold/green glow cells = reward/boost, LEFT/RIGHT = drift between lanes. The first 10 seconds must teach by screen composition and motion, not a long tutorial. The game should feel richer than a single dodge prototype: lane drift, hazard waves, near-miss scoring, boost pickups, combo multiplier, pulse drain, short wave pacing, failure reason, retry reset, pause, sound toggle, and visible best score. Planning and Spec Review must define each system in separate detailed files so Development has no need to invent core behavior. Visual design must include layered moving background, luminous track rails, player trail, hazard warning, pickup pulse, score feedback, failure overlay, and clear typography. QA must include simulator video across at least 3 complete runs, screenshots for menu/gameplay/game-over/retry, runtime probe JSON, PlayMode test evidence, product experience review, first-run comprehension gate, visual richness gate, and gameplay function gate. Build must auto-run locally on Unity 6000.0.77f1 when available; no manual product-code intervention is allowed.

## Product Vision and Purpose（產品願景與目的）

由 Raw Idea 正規化：Create an iOS-first Unity 6000.0.77f1 arcade game MVP named NeonDrift_MVP. The player is a rookie courier piloting a cyan hover ship through a collapsing neon data highway inside a cyber-city. The center playfield must read as a dangerous moving lane/track, not an abstract rectangle. The player must immediately understand: cyan ship = me, neon track = survival lane, pink shards = crash threat, gold/green glow cells = reward/boost, LEFT/RIGHT = drift between lanes. The first 10 seconds must teach by screen composition and motion, not a long tutorial. The game should feel richer than a single dodge prototype: lane drift, hazard waves, near-miss scoring, boost pickups, combo multiplier, pulse drain, short wave pacing, failure reason, retry reset, pause, sound toggle, and visible best score. Planning and Spec Review must define each system in separate detailed files so Development has no need to invent core behavior. Visual design must include layered moving background, luminous track rails, player trail, hazard warning, pickup pulse, score feedback, failure overlay, and clear typography. QA must include simulator video across at least 3 complete runs, screenshots for menu/gameplay/game-over/retry, runtime probe JSON, PlayMode test evidence, product experience review, first-run comprehension gate, visual richness gate, and gameplay function gate. Build must auto-run locally on Unity 6000.0.77f1 when available; no manual product-code intervention is allowed.
遊戲概念：Neon courier drift runner: a cyan hover ship survives a collapsing cyber data highway by drifting left/right between lanes, dodging pink crash shards, collecting glow cells, and chaining near misses for combo score.
玩家目標：Survive 60-second-style short runs as long as possible, keep pulse above zero, dodge hazards, collect boost cells, build combo/near-miss score, beat best score, and retry quickly after a visible failure reason.
必須包含：Detailed planning proposal split into sections; spec review with 

## Target Audience（目標受眾）

由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。

## Core Value（核心價值）

由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。
核心玩法：Tap LEFT to drift one lane left; tap RIGHT to drift one lane right. The track scrolls toward the player. Pink hazard shards approach in readable patterns. Gold/green pickups restore pulse or increase combo. Near misses increase multiplier. Collision or pulse depletion triggers Drift Lost with reason and Retry.
核心物件：Cyan player hover ship, neon data track/lane rails, moving background light tunnel, pink hazard shards, gold boost cells, green combo cells, score HUD, pulse meter, combo/multiplier HUD, wave indicator, pause button, sound/settings, failure overlay, retry button, best score.
視覺方向：High-polish neon arcade look: dark cyber-city depth, cyan/magenta/gold color language, animated lane rails, parallax light tunnel, player glow trail, hazard warning chevrons, pickup pulse rings, readable iPhone portrait HUD, large touch zones, safe-area support, no flat placeholder-only scene.
成功條件：A first-time player can explain what the track is, what they control, what LEFT/RIGHT do, what to avoid, what to collect, why they failed, and what Retry does from screenshots/video alone. QA passes only with video, screenshots, runtime probes, PlayMode tests, first-run comprehension, visual richness, gameplay depth, and retry recovery evidence.
QA 要求：QA must hard fail unless product experience, human visual judgement, first-run gameplay comprehension, gameplay function playability, visual richness, three-run recording, screenshots, runtime probes, PlayMode XML, retry recovery, and delivery files are all present and Passed.

## Platform Target

Unity iOS first; Android/WebGL only as future scope unless explicitly requested.

## Monetization Direction

Rewarded ads may be considered only after failure/retry or future revive/bonus flows; ads must not interrupt the first run or core tutorial experience.

## Compatibility Target

iOS-first Unity 6000.0.77f1, local iOS simulator build, safe-area aware controls, readable on common iPhone portrait screens, performance suitable for mid-range iOS devices.

## Output Expectation

Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input.
References: Use OpenClaw knowledge bases: Apple HIG, product experience first-run clarity, game quality visual richness, game system design, narrative visual storytelling, OpenGameArt asset sourcing and license register, OPDCA_DMAIC_CYCLE.
QA Requirement: QA must hard fail unless product experience, human visual judgement, first-run gameplay comprehension, gameplay function playability, visual richness, three-run recording, screenshots, runtime probes, PlayMode XML, retry recovery, and delivery files are all present and Passed.

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

## Development Request

Normalize this raw idea into canonical product definition for the OpenClaw pipeline.
Preserve the original idea. Do not invent a missing game concept; if a required product/game concept is unclear, keep the Define run blocked instead of allowing Planning to guess.
Raw idea type: game
Priority: high

Raw idea:
Create an iOS-first Unity 6000.0.77f1 arcade game MVP named NeonDrift_MVP. The player is a rookie courier piloting a cyan hover ship through a collapsing neon data highway inside a cyber-city. The center playfield must read as a dangerous moving lane/track, not an abstract rectangle. The player must immediately understand: cyan ship = me, neon track = survival lane, pink shards = crash threat, gold/green glow cells = reward/boost, LEFT/RIGHT = drift between lanes. The first 10 seconds must teach by screen composition and motion, not a long tutorial. The game should feel richer than a single dodge prototype: lane drift, hazard waves, near-miss scoring, boost pickups, combo multiplier, pulse drain, short wave pacing, failure reason, retry reset, pause, sound toggle, and visible best score. Planning and Spec Review must define each system in separate detailed files so Development has no need to invent core behavior. Visual design must include layered moving background, luminous track rails, player trail, hazard warning, pickup pulse, score feedback, failure overlay, and clear typography. QA must include simulator video across at least 3 complete runs, screenshots for menu/gameplay/game-over/retry, runtime probe JSON, PlayMode test evidence, product experience review, first-run comprehension gate, visual richness gate, and gameplay function gate. Build must auto-run locally on Unity 6000.0.77f1 when available; no manual product-code intervention is allowed.

Game concept fields:
Game Concept: Neon courier drift runner: a cyan hover ship survives a collapsing cyber data highway by drifting left/right between lanes, dodging pink crash shards, collecting glow cells, a
