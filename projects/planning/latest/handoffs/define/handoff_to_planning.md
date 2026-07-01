# Handoff: define to planning

```yaml
project_name: 紫微斗數
define_page_id: 390b9e33-8429-81df-87d9-f8de6e4845b1
define_run_id: notion--define-20260701174341
chain_id: raw:unknown:390b9e33-156bcc5c
output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/Untitled_Project/project/
handoff_type: define_to_planning
ready_for_planning: true
planning_stage_range: 0-12
source_documents:
  - docs/define/Defined_Request.md
  - docs/define/Idea_Expansion_Governance.md
  - docs/define/Research_Knowledge_Cards.md
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

## Research Knowledge Capture Contract

Research Knowledge Capture Contract:
- External research is allowed only through bounded source cards. Agents must not paste full web pages, copied article text, competitor screenshots, or unverified claims into downstream context.
- Preferred owners: ux-researcher for player/product/gameplay references; evidence-collector for source-card evidence, attribution, and license risk; technical-artist for asset feasibility; product-experience-reviewer for product-experience synthesis.
- Required knowledge base reads when research is used: research_capture/ROUTING.md, research_capture/SOURCE_CARD_SCHEMA.md, research_capture/VALIDATION_GATES.md, and research_capture/LICENSE_AND_ATTRIBUTION.md.
- Required project outputs when external research is used: docs/research/Research_Source_Cards.md, docs/research/Research_Synthesis.md, docs/research/Research_License_Risk_Register.md, and status/context/research_context_pack.md.
- Each source card must include source_card_id, source_title, source_url, publisher_or_author, accessed_at, source_type, license_or_terms, usage_risk, recommended_for_stage, usable_summary, design_implication, do_not_use_directly, and open_questions.
- Planning and Spec Review must cite source card ids or bounded internal knowledge-base paths for research-based claims.
- Development may directly use external assets only when a source card marks usage_risk=low and direct_asset_use_allowed=true.
- QA must fail if a product claim, asset, platform rule, or product-experience benchmark depends on external research but no source card or license risk record exists.

## Research Source Cards

```yaml
source_card_id: internal-kb-game-quality-001
source_title: OpenClaw Game Quality Knowledge Base
source_url: /home/node/.openclaw/workspace/public_document/knowledge_base/game_quality/README.md
publisher_or_author: OpenClaw internal
accessed_at: define-time
source_type: internal_knowledge_base
license_or_terms: internal project guidance
usage_risk: low
recommended_for_stage: planning, spec_review, development, qa
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: Use GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, QUALITY_RUBRIC.md, and VALIDATION_GATES.md as bounded quality references.
- design_implication: Planning must turn quality goals into concrete player actions, system responses, feedback events, and QA evidence.
- do_not_use_directly: Do not paste whole knowledge-base files into downstream handoffs.
- open_questions: Project-specific benchmark sources still need research capture if Raw Idea asks for external inspiration.

```yaml
source_card_id: internal-kb-research-capture-001
source_title: OpenClaw Research Capture Knowledge Base
source_url: /home/node/.openclaw/workspace/public_document/knowledge_base/research_capture/README.md
publisher_or_author: OpenClaw internal
accessed_at: define-time
source_type: internal_knowledge_base
license_or_terms: internal project guidance
usage_risk: low
recommended_for_stage: raw_idea, define, planning, spec_review, development, qa
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: External research must become source cards with source URL, accessed date, license/terms, usage risk, usable summary, design implication, and do-not-use-directly notes.
- design_implication: Agents may search the web, but downstream stages consume only source cards and synthesis.
- do_not_use_directly: Do not use raw external pages or unlicensed assets as production input.
- open_questions: External references supplied by user must be converted into full source cards before direct downstream use.

```yaml
source_card_id: raw-reference-pending-001
source_title: No explicit raw reference provided
source_url: (not provided)
publisher_or_author: unknown
accessed_at: pending_research_capture
source_type: other
license_or_terms: unknown
usage_risk: medium
recommended_for_stage: define, planning
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: Pending. A research owner must inspect and summarize this reference if it affects product direction.
- design_implication: Treat as inspiration only until converted into validated source card.
- do_not_use_directly: Do not copy text, images, audio, UI, or product claims from this reference before license and source review.
- open_questions: Verify source URL, author/publisher, license/terms, and applicable design implication.

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
- project_name: 紫微斗數
- raw_idea: 簡單使用紫微斗數，起到教學，算命的作用，卦象解說
- product_vision: 由 Raw Idea 正規化：簡單使用紫微斗數，起到教學，算命的作用，卦象解說 遊戲概念：讓一般使用者，也可以很簡單使用的紫微斗數算命軟體 必須包含：紫微斗數教學，注意事項 Define 階段可放大構想，但放大的內容必須放在候選方向、假設或建議方向，不可放入已確認需求。
- target_audience_field: 由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。
- core_value_field: 由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。 核心玩法：使用中國人所說的生辰八字，最好是用西曆來換算成農曆，來取得命盤大數據 核心物件：紫微斗數，姓名學，算命 成功條件：可以算命？
- platform_target_field: iOS app first, local iOS simulator build and QA delivery required.
- monetization_direction_field: Raw Idea 未明確指定時，不預設付費牆；若是遊戲，先保留 rewarded ads 優先且不得破壞核心體驗，並由 Define/Spec Review 細化。
- compatibility_target_field: iOS first: current iOS simulator/local build gate. Device targets and OS floor must be refined by Define/Spec Review.
- output_expectation_field: Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input.

### Expansion Candidates
- Candidate 1: Readable Action Survival | Player performs one clear repeated action to avoid pressure and earn score/reward while learning risk through visible feedback. | status=Candidate, not confirmed
- Candidate 2: Timed Pressure Run | Player acts on timed pulses/windows; correct timing grants combo/boost, late or wrong action increases danger. | status=Candidate, not confirmed
- Candidate 3: Progressive Mastery Challenge | The MVP adds staged hazard patterns, combo rules, simple unlock/progression, and post-run feedback so each retry teaches a new skill. | status=Candidate, not confirmed

### Recommended Direction

- Recommended, not confirmed: select one primary repeated action in Planning, then combine Readable Action Survival with Progressive Mastery Challenge to avoid a static or unclear prototype.
- status=Recommended, not confirmed

### Open Questions
- Which Expansion Candidate should be treated as the MVP direction, or should Planning compare all candidates first?
- What is the strongest intended player feeling: speed, mastery, tension, relaxation, strategy, collection, or spectacle?
- Which visual references are approved, and which are only inspirational?
- What must be excluded from MVP scope even if it would increase depth or polish?
- What is the minimum acceptable device/OS compatibility target for release, not only simulator testing?

## Next Step

Create a Planning row from this canonical defined request. Do not read unbounded raw request text.
