# Defined Request

## Canonical Fields

- project_name: NeonDrift_MVP
- define_page_id: 38ab9e33-8429-811c-b36b-d41dc97b37d9
- define_run_id: notion-NeonDrift_MVP-define-20260625180313
- agent_model_policy: per-agent-config
- thinking: off

## Raw Idea（原始想法）

Create an iOS-first Unity quick game MVP named NeonDrift_MVP. Run OpenClaw pipeline from Raw Idea -> Define -> Planning -> Spec Review -> Development only. Do not create or start Build or QA rows in this test. Planning and Spec Review must not produce summary-only documents. Every major planning output must behave like Game_Proposal: an index plus detailed source_paths/context cards when the topic is broad. One_Page_Game_Concept, Core_Gameplay_Loop, MVP_Hypothesis, Platform_Direction, visual richness, gameplay depth, product experience, compatibility, QA acceptance, and development handoff must all be split into concrete cards with player-visible behavior, gameplay depth, visual richness, runtime evidence, QA acceptance, downstream read policy, and implementation constraints. Development must consume those split cards and produce an implementation-ready Unity project, but this run stops after Development passed.

## Product Vision and Purpose（產品願景與目的）

由 Raw Idea 正規化：Create an iOS-first Unity quick game MVP named NeonDrift_MVP. Run OpenClaw pipeline from Raw Idea -> Define -> Planning -> Spec Review -> Development only. Do not create or start Build or QA rows in this test. Planning and Spec Review must not produce summary-only documents. Every major planning output must behave like Game_Proposal: an index plus detailed source_paths/context cards when the topic is broad. One_Page_Game_Concept, Core_Gameplay_Loop, MVP_Hypothesis, Platform_Direction, visual richness, gameplay depth, product experience, compatibility, QA acceptance, and development handoff must all be split into concrete cards with player-visible behavior, gameplay depth, visual richness, runtime evidence, QA acceptance, downstream read policy, and implementation constraints. Development must consume those split cards and produce an implementation-ready Unity project, but this run stops after Development passed.
Define 階段需補齊痛點、服務目標、MVP 邊界與可驗證成功條件；若資訊不足，必須保留為 open questions。

## Target Audience（目標受眾）

由 Raw Idea 推導目標受眾；若原始想法未指定，先假設為 iOS 手機端使用者/玩家，並在 Define 階段標記需驗證。

## Core Value（核心價值）

由 Raw Idea 提煉 1-3 個核心價值；初始假設是操作/使用流程清楚、短時間可驗證、iOS 交付可測。

## Platform Target

Unity iOS first; Android/WebGL only as future scope unless explicitly requested.

## Monetization Direction

Raw Idea 未明確指定時，不預設付費牆；若是遊戲，先保留 rewarded ads 優先且不得破壞核心體驗，並由 Define/Spec Review 細化。

## Compatibility Target

iOS first: current iOS simulator/local build gate. Device targets and OS floor must be refined by Define/Spec Review.

## Output Expectation

Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input.

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
Preserve the original idea, infer only conservative assumptions, and mark unresolved items as open questions in Define outputs.
Raw idea type: game
Priority: high

Raw idea:
Create an iOS-first Unity quick game MVP named NeonDrift_MVP. Run OpenClaw pipeline from Raw Idea -> Define -> Planning -> Spec Review -> Development only. Do not create or start Build or QA rows in this test. Planning and Spec Review must not produce summary-only documents. Every major planning output must behave like Game_Proposal: an index plus detailed source_paths/context cards when the topic is broad. One_Page_Game_Concept, Core_Gameplay_Loop, MVP_Hypothesis, Platform_Direction, visual richness, gameplay depth, product experience, compatibility, QA acceptance, and development handoff must all be split into concrete cards with player-visible behavior, gameplay depth, visual richness, runtime evidence, QA acceptance, downstream read policy, and implementation constraints. Development must consume those split cards and produce an implementation-ready Unity project, but this run stops after Development passed.
